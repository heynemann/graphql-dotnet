load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "core_library")

core_library(
    name = "graphql-dotnet.dll",
    srcs = glob(
        [
            "src/**/*.cs",
        ],
        exclude = [
            "src/GraphQL.Tests/**/*",
            "src/GraphQL.DataLoader.Tests/**/*",
            "src/GraphQL.ApiTests/**/*",
            "src/GraphQL.Benchmarks/**/*",
            "src/GraphQL.Harness.Tests/**/*",
            "src/GraphQL.Harness/**/*",
        ],
    ),
    deps = [
        "@newtonsoft.json//:netcoreapp3.1_core",
        "@graphql-parser//:netcoreapp3.1_core",
        "@system.reactive//:netcoreapp2.1_core",
        "@io_bazel_rules_dotnet//dotnet/stdlib.core:Microsoft.AspNetCore.App",
        "@io_bazel_rules_dotnet//dotnet/stdlib.core:libraryset",
    ],
)
