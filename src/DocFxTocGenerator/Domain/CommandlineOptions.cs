﻿// Licensed to DocFX Companion Tools and contributors under one or more agreements.
// DocFX Companion Tools and contributors licenses this file to you under the MIT license.

namespace DocFxTocGenerator.Domain
{
    using CommandLine;

    /// <summary>
    /// Class for command line options.
    /// </summary>
    public class CommandlineOptions
    {
        /// <summary>
        /// Gets or sets the folder with documents.
        /// </summary>
        [Option('d', "docfolder", Required = true, HelpText = "Folder containing the documents.")]
        public string DocFolder { get; set; }

        /// <summary>
        /// Gets or sets the folder with documents.
        /// </summary>
        [Option('o', "outputfolder", Required = false, HelpText = "Folder to write the resulting toc.yml in.")]
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether verbose information is shown in the output.
        /// </summary>
        [Option('v', "verbose", Required = false, HelpText = "Show verbose messages.")]
        public bool Verbose { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the .order files are used.
        /// </summary>
        [Option('s', "sequence", Required = false, HelpText = "Use the .order files for TOC sequence. Format are raws of: filename-without-extension")]
        public bool UseOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the .override files are used.
        /// </summary>
        [Option('r', "override", Required = false, HelpText = "Use the .override files for TOC file name override. Format are raws of: filename-without-extension;Title you want")]
        public bool UseOverride { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the .ignore files are used.
        /// </summary>
        [Option('g', "ignore", Required = false, HelpText = "Use the .ignore files for TOC directory ignore. Format are raws of directory names: directory-to-ignore")]
        public bool UseIgnore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an index is automatically added.
        /// </summary>
        [Option('i', "index", Required = false, HelpText = "Auto-generate a file index in each folder.")]
        public bool AutoIndex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether NOT to generate an index in a folder with 1 file.
        /// Is supplementary to the -i option and doesn't work without that flag.
        /// </summary>
        [Option('n', "notwithone", Required = false, HelpText = "Do not auto-generate a file index when only contains 1 file. Additional to -i flag.")]
        public bool NoAutoIndexWithOneFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multiple toc files should be generated for each of the first child subfolders instead of building
        /// one large toc in the root output folder.
        /// </summary>
        [Option('m', "multitoc", Required = false, HelpText = "Indicates how deep in the tree toc files should be generated for child subfolders, a depth of 0 is the root only.")]
        public int SplitTocDepth { get; set; } = 0;

        /// <summary>
        /// Gets or sets a value indicating whether child folders that have the same name as a sibling document should automatically
        /// be linked as child items to the document instead of creating two entries for the document and one for the folder.
        /// </summary>
        [Option('l', "linkchildren", Required = false, HelpText = "Automatically link folders with same title to parent documents as child items.")]
        public bool LinkChildFolder { get; set; }
    }
}
