# DocFX Companion Tools

This repository contains a series of tools, templates, tips and tricks to make your [DocFX](https://dotnet.github.io/docfx/) life even better. You will find the following elements in this repository:

* [TocDocFxCreation](./TocDocFxCreation): an advanced tool to create automatically a Table of Contents (TOC) in Yaml format for DocFX. It has cool features like ability to configure the order of files, using the real main level title in the files themselves for the TOC name entry, override possibility per folder for those titles and more!
* [DocLinkChecker](./DocLinkChecker): a tool to check and clean a `.attachments` folder where all attachments should be stored, validate the links in all the files. It raises an error on validation errors. And it has the ability to automatically clean the .attachments folder. This is a handy tool to be used in CI pipelines as well.
* [Documentation ready to use](./DocExample/docs/markdownlint.md) on how to use [Markdownlint](https://github.com/DavidAnson/markdownlint) to give to your developers.
* [Ready to use](./DocExample/docs/markdown-creation.md) rules for creating Markdown in a repository to give to your developers. This contains patterns, tips and tricks as well.
* [End user documentation](./DocExample/docs/enduser-documentation.md) guidelines ready to use by your developers.
* [Specific elements](./DocExample/docs/ui-specific-elements.md) to add and consider for proper usage and support for Mermaid.

## License

Please read the main [license file](LICENSE) and the sub folder license files. Most of those tools are coming from a work done with [ZF](https://www.zf.com/).
