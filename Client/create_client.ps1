#!/usr/bin/pwsh

param(
[string]$swagger_file = "swagger.json",
[string]$output_dir = "client-auto-get",
[string]$package_name = "OpenApiGeneratorTest.WebApi.Client",
[string]$target_framework = "net8.0",
[ValidateSet("docker", "podman")]
[string]$container_runtime = "docker"
)

if (Test-Path ${output_dir})
{
    remove-item -Path ${output_dir} -Force -Recurse
}

mkdir ${output_dir}

& $container_runtime run --rm -v ${PWD}:/local openapitools/openapi-generator-cli:v7.5.0 generate -i /local/${swagger_file} -g csharp -o /local/${output_dir} --additional-properties=packageName=${package_name} --additional-properties=targetFramework=${target_framework} --additional-properties=useDateTimeOffset=true

Remove-Item -Path ./Api -Recurse -Force
Remove-Item -Path ./Client -Recurse -Force
Remove-Item -Path ./Model -Recurse -Force

mv ${output_dir}/src/${package_name}/Api .
mv ${output_dir}/src/${package_name}/Client .
mv ${output_dir}/src/${package_name}/Model .

Remove-Item -Path ${output_dir}  -Recurse -Force