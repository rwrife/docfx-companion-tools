# DocFX Companion Tools

This repository contains a series of tools, templates, tips and tricks to make your [DocFX](https://dotnet.github.io/docfx/) life even better.

## Tools

* [TocDocFxCreation](./TocDocFxCreation): generate a Table of Contents (TOC) in YAML format for DocFX. It has features like the ability to configure the order of files and the names of documents and folders.
* [DocLinkChecker](./DocLinkChecker): validate links in documents and check for orphaned attachments in the `.attachments` folder. The tool indicates whether there are errors or warnings, so it can be used in a CI pipeline. It can also clean up orphaned attachments automatically.

## Documentation

* [Guidelines on how to use Markdownlint](./DocExample/docs/markdownlint.md) for your developers.
* [Guidelines for creating Markdown docs](./DocExample/docs/markdown-creation.md) for your developers. This contains patterns as well as tips and tricks.
* [Guidelines for end user documentation](./DocExample/docs/enduser-documentation.md) for your developers.
* Specific elements to add and consider for [proper usage and support for Mermaid](./DocExample/docs/ui-specific-elements.md).

## License

Please read the main [license file](LICENSE) and the sub folder license files. Most of those tools are coming from a work done with [ZF](https://www.zf.com/).
