///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          Constants
///   Description:    A static class which contains a lot of 
///                   contants
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

using System;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which contains a lot of contants
    /// </summary>
    internal static class Constants {
        /// <summary>
        /// This class defines all possible tags generated
        /// by "doxygen -g "configFile".
        /// The name of every tags pratically is the content
        /// e.g.
        ///     K_PROJECT_LOGO = "PROJECT_LOGO";
        /// </summary>
        public const String K_REGEX_Everything = "((.|\n)*?)";

        public const String K_DOXYFILE_ENCODING = "DOXYFILE_ENCODING";
        public const String K_PROJECT_NAME = "PROJECT_NAME";
        public const String K_PROJECT_NUMBER = "PROJECT_NUMBER";
        public const String K_PROJECT_BRIEF = "PROJECT_BRIEF";
        public const String K_PROJECT_LOGO = "PROJECT_LOGO";
        public const String K_OUTPUT_DIRECTORY = "OUTPUT_DIRECTORY";
        public const String K_CREATE_SUBDIRS = "CREATE_SUBDIRS";
        public const String K_ALLOW_UNICODE_NAMES = "ALLOW_UNICODE_NAMES";
        public const String K_OUTPUT_LANGUAGE = "OUTPUT_LANGUAGE";
        public const String K_BRIEF_MEMBER_DESC = "BRIEF_MEMBER_DESC";
        public const String K_REPEAT_BRIEF = "REPEAT_BRIEF";
        public const String K_ABBREVIATE_BRIEF = "ABBREVIATE_BRIEF";
        public const String K_ALWAYS_DETAILED_SEC = "ALWAYS_DETAILED_SEC";
        public const String K_INLINE_INHERITED_MEMB = "INLINE_INHERITED_MEMB";
        public const String K_FULL_PATH_NAMES = "FULL_PATH_NAMES";
        public const String K_STRIP_FROM_PATH = "STRIP_FROM_PATH";
        public const String K_STRIP_FROM_INC_PATH = "STRIP_FROM_INC_PATH";
        public const String K_SHORT_NAMES = "SHORT_NAMES";
        public const String K_JAVADOC_AUTOBRIEF = "JAVADOC_AUTOBRIEF";
        public const String K_QT_AUTOBRIEF = "QT_AUTOBRIEF";
        public const String K_MULTILINE_CPP_IS_BRIEF = "MULTILINE_CPP_IS_BRIEF";
        public const String K_INHERIT_DOCS = "INHERIT_DOCS";
        public const String K_SEPARATE_MEMBER_PAGES = "SEPARATE_MEMBER_PAGES";
        public const String K_TAB_SIZE = "TAB_SIZE";
        public const String K_ALIASES = "ALIASES";
        public const String K_TCL_SUBST = "TCL_SUBST";
        public const String K_OPTIMIZE_OUTPUT_FOR_C = "OPTIMIZE_OUTPUT_FOR_C";
        public const String K_OPTIMIZE_OUTPUT_JAVA = "OPTIMIZE_OUTPUT_JAVA";
        public const String K_OPTIMIZE_FOR_FORTRAN = "OPTIMIZE_FOR_FORTRAN";
        public const String K_OPTIMIZE_OUTPUT_VHDL = "OPTIMIZE_OUTPUT_VHDL";
        public const String K_EXTENSION_MAPPING = "EXTENSION_MAPPING";
        public const String K_MARKDOWN_SUPPORT = "MARKDOWN_SUPPORT";
        public const String K_AUTOLINK_SUPPORT = "AUTOLINK_SUPPORT";
        public const String K_BUILTIN_STL_SUPPORT = "BUILTIN_STL_SUPPORT";
        public const String K_CPP_CLI_SUPPORT = "CPP_CLI_SUPPORT";
        public const String K_SIP_SUPPORT = "SIP_SUPPORT";
        public const String K_IDL_PROPERTY_SUPPORT = "IDL_PROPERTY_SUPPORT";
        public const String K_DISTRIBUTE_GROUP_DOC = "DISTRIBUTE_GROUP_DOC";
        public const String K_SUBGROUPING = "SUBGROUPING";
        public const String K_INLINE_GROUPED_CLASSES = "INLINE_GROUPED_CLASSES";
        public const String K_INLINE_SIMPLE_STRUCTS = "INLINE_SIMPLE_STRUCTS";
        public const String K_TYPEDEF_HIDES_STRUCT = "TYPEDEF_HIDES_STRUCT";
        public const String K_LOOKUP_CACHE_SIZE = "LOOKUP_CACHE_SIZE";
        public const String K_EXTRACT_ALL = "EXTRACT_ALL";
        public const String K_EXTRACT_PRIVATE = "EXTRACT_PRIVATE";
        public const String K_EXTRACT_PACKAGE = "EXTRACT_PACKAGE";
        public const String K_EXTRACT_STATIC = "EXTRACT_STATIC";
        public const String K_EXTRACT_LOCAL_CLASSES = "EXTRACT_LOCAL_CLASSES";
        public const String K_EXTRACT_LOCAL_METHODS = "EXTRACT_LOCAL_METHODS";
        public const String K_EXTRACT_ANON_NSPACES = "EXTRACT_ANON_NSPACES";
        public const String K_HIDE_UNDOC_MEMBERS = "HIDE_UNDOC_MEMBERS";
        public const String K_HIDE_UNDOC_CLASSES = "HIDE_UNDOC_CLASSES";
        public const String K_HIDE_FRIEND_COMPOUNDS = "HIDE_FRIEND_COMPOUNDS";
        public const String K_HIDE_IN_BODY_DOCS = "HIDE_IN_BODY_DOCS";
        public const String K_INTERNAL_DOCS = "INTERNAL_DOCS";
        public const String K_CASE_SENSE_NAMES = "CASE_SENSE_NAMES";
        public const String K_HIDE_SCOPE_NAMES = "HIDE_SCOPE_NAMES";
        public const String K_HIDE_COMPOUND_REFERENCE = "HIDE_COMPOUND_REFERENCE";
        public const String K_SHOW_INCLUDE_FILES = "SHOW_INCLUDE_FILES";
        public const String K_SHOW_GROUPED_MEMB_INC = "SHOW_GROUPED_MEMB_INC";
        public const String K_FORCE_LOCAL_INCLUDES = "FORCE_LOCAL_INCLUDES";
        public const String K_INLINE_INFO = "INLINE_INFO";
        public const String K_SORT_MEMBER_DOCS = "SORT_MEMBER_DOCS";
        public const String K_SORT_BRIEF_DOCS = "SORT_BRIEF_DOCS"; 
        public const String K_SORT_MEMBERS_CTORS_1ST = "SORT_MEMBERS_CTORS_1ST";
        public const String K_SORT_GROUP_NAMES = "SORT_GROUP_NAMES";
        public const String K_SORT_BY_SCOPE_NAME = "SORT_BY_SCOPE_NAME";
        public const String K_STRICT_PROTO_MATCHING = "STRICT_PROTO_MATCHING";  // = NO
        public const String K_GENERATE_TODOLIST = "GENERATE_TODOLIST";      // = YES
        public const String K_GENERATE_TESTLIST = "GENERATE_TESTLIST";      // = YES
        public const String K_GENERATE_BUGLIST = "GENERATE_BUGLIST";       // = YES
        public const String K_GENERATE_DEPRECATEDLIST = "GENERATE_DEPRECATEDLIST";// = YES
        public const String K_ENABLED_SECTIONS = "ENABLED_SECTIONS";       // =
        public const String K_MAX_INITIALIZER_LINES = "MAX_INITIALIZER_LINES";  // = 30
        public const String K_SHOW_USED_FILES = "SHOW_USED_FILES";        // = YES
        public const String K_SHOW_FILES = "SHOW_FILES";             // = YES
        public const String K_SHOW_NAMESPACES = "SHOW_NAMESPACES";        // = YES
        public const String K_FILE_VERSION_FILTER = "FILE_VERSION_FILTER";    // =
        public const String K_LAYOUT_FILE = "LAYOUT_FILE";            // =
        public const String K_CITE_BIB_FILES = "CITE_BIB_FILES";         // =
        public const String K_QUIET = "QUIET";                  // = NO
        public const String K_WARNINGS = "WARNINGS";               // = YES
        public const String K_WARN_IF_UNDOCUMENTED = "WARN_IF_UNDOCUMENTED";   // = YES
        public const String K_WARN_IF_DOC_ERROR = "WARN_IF_DOC_ERROR";      // = YES
        public const String K_WARN_NO_PARAMDOC = "WARN_NO_PARAMDOC";       // = NO
        public const String K_WARN_FORMAT = "WARN_FORMAT";            // = "$file:$line: $tex";
        public const String K_WARN_LOGFILE = "WARN_LOGFILE";           // =
        public const String K_INPUT = "INPUT";                  // = "F:\aboutMyFutureProjects\doxygen\exCSharpDoc";
        public const String K_INPUT_ENCODING = "INPUT_ENCODING";         // = UTF-8
        public const String K_FILE_PATTERNS = "FILE_PATTERNS";          // = *.cs
        public const String K_RECURSIVE = "RECURSIVE";              // = YES
        public const String K_EXCLUDE = "EXCLUDE";                // =
        public const String K_EXCLUDE_SYMLINKS = "EXCLUDE_SYMLINKS";       // = NO
        public const String K_EXCLUDE_PATTERNS = "EXCLUDE_PATTERNS";       // =
        public const String K_EXCLUDE_SYMBOLS = "EXCLUDE_SYMBOLS";        // =
        public const String K_EXAMPLE_PATH = "EXAMPLE_PATH";           // =
        public const String K_EXAMPLE_PATTERNS = "EXAMPLE_PATTERNS";       // =
        public const String K_EXAMPLE_RECURSIVE = "EXAMPLE_RECURSIVE";      // = NO
        public const String K_IMAGE_PATH = "IMAGE_PATH";             // =
        public const String K_INPUT_FILTER = "INPUT_FILTER";           // =
        public const String K_FILTER_PATTERNS = "FILTER_PATTERNS";        // =
        public const String K_FILTER_SOURCE_FILES = "FILTER_SOURCE_FILES";    // = NO
        public const String K_FILTER_SOURCE_PATTERNS = "FILTER_SOURCE_PATTERNS"; // =
        public const String K_USE_MDFILE_AS_MAINPAGE = "USE_MDFILE_AS_MAINPAGE"; // =
        public const String K_SOURCE_BROWSER = "SOURCE_BROWSER";         // = NO
        public const String K_INLINE_SOURCES = "INLINE_SOURCES";         // = NO
        public const String K_STRIP_CODE_COMMENTS = "STRIP_CODE_COMMENTS";    // = YES
        public const String K_REFERENCED_BY_RELATION = "REFERENCED_BY_RELATION"; // = NO
        public const String K_REFERENCES_RELATION = "REFERENCES_RELATION";    // = NO
        public const String K_REFERENCES_LINK_SOURCE = "REFERENCES_LINK_SOURCE"; // = YES
        public const String K_SOURCE_TOOLTIPS = "SOURCE_TOOLTIPS";        // = YES
        public const String K_USE_HTAGS = "USE_HTAGS";              // = NO
        public const String K_VERBATIM_HEADERS = "VERBATIM_HEADERS";       // = YES
        public const String K_ALPHABETICAL_INDEX = "ALPHABETICAL_INDEX";     // = YES
        public const String K_COLS_IN_ALPHA_INDEX = "COLS_IN_ALPHA_INDEX";   // = 5
        public const String K_IGNORE_PREFIX = "IGNORE_PREFIX";          // =
        public const String K_GENERATE_HTML = "GENERATE_HTML";          // = YES
        public const String K_HTML_OUTPUT = "HTML_OUTPUT";            // = html
        public const String K_HTML_FILE_EXTENSION = "HTML_FILE_EXTENSION";    // = .html
        public const String K_HTML_HEADER = "HTML_HEADER";            // =
        public const String K_HTML_FOOTER = "HTML_FOOTER";            // =
        public const String K_HTML_STYLESHEET = "HTML_STYLESHEET";        // =
        public const String K_HTML_EXTRA_STYLESHEET = "HTML_EXTRA_STYLESHEET";  // =
        public const String K_HTML_EXTRA_FILES = "HTML_EXTRA_FILES";       // =
        public const String K_HTML_COLORSTYLE_HUE = "HTML_COLORSTYLE_HUE";    // = 220
        public const String K_HTML_COLORSTYLE_SAT = "HTML_COLORSTYLE_SAT";    // = 100
        public const String K_HTML_COLORSTYLE_GAMMA = "HTML_COLORSTYLE_GAMMA";  // = 80
        public const String K_HTML_TIMESTAMP = "HTML_TIMESTAMP";         // = YES
        public const String K_HTML_DYNAMIC_SECTIONS = "HTML_DYNAMIC_SECTIONS";  // = NO
        public const String K_HTML_INDEX_NUM_ENTRIES = "HTML_INDEX_NUM_ENTRIES"; // = 100
        public const String K_GENERATE_DOCSET = "GENERATE_DOCSET";        // = NO
        public const String K_DOCSET_FEEDNAME = "DOCSET_FEEDNAME";        // = "Doxygen generated doc";
        public const String K_DOCSET_BUNDLE_ID = "DOCSET_BUNDLE_ID";       // = org.doxygen.Project
        public const String K_DOCSET_PUBLISHER_ID = "DOCSET_PUBLISHER_ID";    // = org.doxygen.Publisher
        public const String K_DOCSET_PUBLISHER_NAME = "DOCSET_PUBLISHER_NAME";  // = Publisher
        public const String K_GENERATE_HTMLHELP = "GENERATE_HTMLHELP";      // = NO
        public const String K_CHM_FILE = "CHM_FILE";               // =
        public const String K_HHC_LOCATION = "HHC_LOCATION";           // =
        public const String K_GENERATE_CHI = "GENERATE_CHI";           // = NO
        public const String K_CHM_INDEX_ENCODING = "CHM_INDEX_ENCODING";     // =
        public const String K_BINARY_TOC = "BINARY_TOC";             // = NO
        public const String K_TOC_EXPAND = "TOC_EXPAND";             // = NO
        public const String K_GENERATE_QHP = "GENERATE_QHP";           // = NO
        public const String K_QCH_FILE = "QCH_FILE";               // =
        public const String K_QHP_NAMESPACE = "QHP_NAMESPACE";          // = org.doxygen.Project
        public const String K_QHP_VIRTUAL_FOLDER = "QHP_VIRTUAL_FOLDER";     // = doc
        public const String K_QHP_CUST_FILTER_NAME = "QHP_CUST_FILTER_NAME";   // =
        public const String K_QHP_CUST_FILTER_ATTRS = "QHP_CUST_FILTER_ATTRS";  // =
        public const String K_QHP_SECT_FILTER_ATTRS = "QHP_SECT_FILTER_ATTRS";  // =
        public const String K_QHG_LOCATION = "QHG_LOCATION";          // =
        public const String K_GENERATE_ECLIPSEHELP = "GENERATE_ECLIPSEHELP";   // = NO
        public const String K_ECLIPSE_DOC_ID = "ECLIPSE_DOC_ID";         // = org.doxygen.Project
        public const String K_DISABLE_INDEX = "DISABLE_INDEX";          // = NO
        public const String K_GENERATE_TREEVIEW = "GENERATE_TREEVIEW";      // = NO
        public const String K_ENUM_VALUES_PER_LINE = "ENUM_VALUES_PER_LINE";   // = 4
        public const String K_TREEVIEW_WIDTH = "TREEVIEW_WIDTH";         // = 250
        public const String K_EXT_LINKS_IN_WINDOW = "EXT_LINKS_IN_WINDOW";    // = NO
        public const String K_FORMULA_FONTSIZE = "FORMULA_FONTSIZE";       // = 10
        public const String K_FORMULA_TRANSPARENT = "FORMULA_TRANSPARENT";    // = YES
        public const String K_USE_MATHJAX = "USE_MATHJAX";            // = NO
        public const String K_MATHJAX_FORMAT = "MATHJAX_FORMAT";         // = HTML-CSS
        public const String K_MATHJAX_RELPATH = "MATHJAX_RELPATH";        // = http://cdn.mathjax.org/mathjax/latest
        public const String K_MATHJAX_EXTENSIONS = "MATHJAX_EXTENSIONS";     // =
        public const String K_MATHJAX_CODEFILE = "MATHJAX_CODEFILE";       // =
        public const String K_SEARCHENGINE = "SEARCHENGINE";           // = YES
        public const String K_SERVER_BASED_SEARCH = "SERVER_BASED_SEARCH";    // = NO
        public const String K_EXTERNAL_SEARCH = "EXTERNAL_SEARCH";        // = NO
        public const String K_SEARCHENGINE_URL = "SEARCHENGINE_URL";       // =
        public const String K_SEARCHDATA_FILE = "SEARCHDATA_FILE";        // = searchdata.xml
        public const String K_EXTERNAL_SEARCH_ID = "EXTERNAL_SEARCH_ID";     // =
        public const String K_EXTRA_SEARCH_MAPPINGS = "EXTRA_SEARCH_MAPPINGS";  // =
        public const String K_GENERATE_LATEX = "GENERATE_LATEX";         // = NO
        public const String K_LATEX_OUTPUT = "LATEX_OUTPUT";           // = latex
        public const String K_LATEX_CMD_NAME = "LATEX_CMD_NAME";         // = latex
        public const String K_MAKEINDEX_CMD_NAME = "MAKEINDEX_CMD_NAME";     // = makeindex
        public const String K_COMPACT_LATEX = "COMPACT_LATEX";          // = NO
        public const String K_PAPER_TYPE = "PAPER_TYPE";             // = a4
        public const String K_EXTRA_PACKAGES = "EXTRA_PACKAGES";         // =
        public const String K_LATEX_HEADER = "LATEX_HEADER";           // =
        public const String K_LATEX_FOOTER = "LATEX_FOOTER";           // =
        public const String K_LATEX_EXTRA_FILES = "LATEX_EXTRA_FILES";      // =
        public const String K_PDF_HYPERLINKS = "PDF_HYPERLINKS";         // = YES
        public const String K_USE_PDFLATEX = "USE_PDFLATEX";           // = YES
        public const String K_LATEX_BATCHMODE = "LATEX_BATCHMODE";        // = NO
        public const String K_LATEX_HIDE_INDICES = "LATEX_HIDE_INDICES";     // = NO
        public const String K_LATEX_SOURCE_CODE = "LATEX_SOURCE_CODE";      // = NO
        public const String K_LATEX_BIB_STYLE = "LATEX_BIB_STYLE";        // = plain
        public const String K_GENERATE_RTF = "GENERATE_RTF";           // = NO
        public const String K_RTF_OUTPUT = "RTF_OUTPUT";             // = rtf
        public const String K_COMPACT_RTF = "COMPACT_RTF";            // = NO
        public const String K_RTF_HYPERLINKS = "RTF_HYPERLINKS";         // = NO
        public const String K_RTF_STYLESHEET_FILE = "RTF_STYLESHEET_FILE";    // =
        public const String K_RTF_EXTENSIONS_FILE = "RTF_EXTENSIONS_FILE";    // =
        public const String K_GENERATE_MAN = "GENERATE_MAN";           // = NO
        public const String K_MAN_OUTPUT = "MAN_OUTPUT";             // = man
        public const String K_MAN_EXTENSION = "MAN_EXTENSION";          // = .3
        public const String K_MAN_SUBDIR = "MAN_SUBDIR";             // =
        public const String K_MAN_LINKS = "MAN_LINKS";              // = NO
        public const String K_GENERATE_XML = "GENERATE_XML";           // = NO
        public const String K_XML_OUTPUT = "XML_OUTPUT";             // = xml
        public const String K_XML_PROGRAMLISTING = "XML_PROGRAMLISTING";     // = YES
        public const String K_GENERATE_DOCBOOK = "GENERATE_DOCBOOK";       // = NO
        public const String K_DOCBOOK_OUTPUT = "DOCBOOK_OUTPUT";         // = docbook
        public const String K_DOCBOOK_PROGRAMLISTING = "DOCBOOK_PROGRAMLISTING"; // = NO
        public const String K_GENERATE_AUTOGEN_DEF = "GENERATE_AUTOGEN_DEF";   // = NO
        public const String K_GENERATE_PERLMOD = "GENERATE_PERLMOD";       // = NO
        public const String K_PERLMOD_LATEX = "PERLMOD_LATEX";          // = NO
        public const String K_PERLMOD_PRETTY = "PERLMOD_PRETTY";         // = YES
        public const String K_PERLMOD_MAKEVAR_PREFIX = "PERLMOD_MAKEVAR_PREFIX"; // =
        public const String K_ENABLE_PREPROCESSING = "ENABLE_PREPROCESSING";   // = YES
        public const String K_MACRO_EXPANSION = "MACRO_EXPANSION";        // = NO
        public const String K_EXPAND_ONLY_PREDEF = "EXPAND_ONLY_PREDEF";     // = NO
        public const String K_SEARCH_INCLUDES = "SEARCH_INCLUDES";        // = YES
        public const String K_INCLUDE_PATH = "INCLUDE_PATH";           // =
        public const String K_INCLUDE_FILE_PATTERNS = "INCLUDE_FILE_PATTERNS";  // =
        public const String K_PREDEFINED = "PREDEFINED";             // =
        public const String K_EXPAND_AS_DEFINED = "EXPAND_AS_DEFINED";      // =
        public const String K_SKIP_FUNCTION_MACROS = "SKIP_FUNCTION_MACROS";   // = YES
        public const String K_TAGFILES = "TAGFILES";               // =
        public const String K_GENERATE_TAGFILE = "GENERATE_TAGFILE";       // =
        public const String K_ALLEXTERNALS = "ALLEXTERNALS";           // = NO
        public const String K_EXTERNAL_GROUPS = "EXTERNAL_GROUPS";        // = YES
        public const String K_EXTERNAL_PAGES = "EXTERNAL_PAGES";         // = YES
        public const String K_PERL_PATH = "PERL_PATH";              // = /usr/bin/perl
        public const String K_CLASS_DIAGRAMS = "CLASS_DIAGRAMS";         // = YES
        public const String K_MSCGEN_PATH = "MSCGEN_PATH";            // =
        public const String K_DIA_PATH = "DIA_PATH";               // =
        public const String K_HIDE_UNDOC_RELATIONS = "HIDE_UNDOC_RELATIONS";   // = YES
        public const String K_HAVE_DOT = "HAVE_DOT";               // = NO
        public const String K_DOT_NUM_THREADS = "DOT_NUM_THREADS";        // = 0
        public const String K_DOT_FONTNAME = "DOT_FONTNAME";           // = Helvetica
        public const String K_DOT_FONTSIZE = "DOT_FONTSIZE";           // = 10
        public const String K_DOT_FONTPATH = "DOT_FONTPATH";           // =
        public const String K_CLASS_GRAPH = "CLASS_GRAPH";            // = YES
        public const String K_COLLABORATION_GRAPH = "COLLABORATION_GRAPH";    // = YES
        public const String K_GROUP_GRAPHS = "GROUP_GRAPHS";           // = YES
        public const String K_UML_LOOK = "UML_LOOK";               // = NO
        public const String K_UML_LIMIT_NUM_FIELDS = "UML_LIMIT_NUM_FIELDS";   // = 10
        public const String K_TEMPLATE_RELATIONS = "TEMPLATE_RELATIONS";     // = NO
        public const String K_INCLUDE_GRAPH = "INCLUDE_GRAPH";          // = YES
        public const String K_INCLUDED_BY_GRAPH = "INCLUDED_BY_GRAPH";      // = YES
        public const String K_CALL_GRAPH = "CALL_GRAPH";             // = NO
        public const String K_CALLER_GRAPH = "CALLER_GRAPH";           // = NO
        public const String K_GRAPHICAL_HIERARCHY = "GRAPHICAL_HIERARCHY";    // = YES
        public const String K_DIRECTORY_GRAPH = "DIRECTORY_GRAPH";        // = YES
        public const String K_DOT_IMAGE_FORMAT = "DOT_IMAGE_FORMAT";       // = png
        public const String K_INTERACTIVE_SVG = "INTERACTIVE_SVG";        // = NO
        public const String K_DOT_PATH = "DOT_PATH";               // =
        public const String K_DOTFILE_DIRS = "DOTFILE_DIRS";           // =
        public const String K_MSCFILE_DIRS = "MSCFILE_DIRS";           // =
        public const String K_DIAFILE_DIRS = "DIAFILE_DIRS";           // =
        public const String K_PLANTUML_JAR_PATH = "PLANTUML_JAR_PATH";      // =
        public const String K_PLANTUML_INCLUDE_PATH = "PLANTUML_INCLUDE_PATH";  // =
        public const String K_DOT_GRAPH_MAX_NODES = "DOT_GRAPH_MAX_NODES";    // = 50
        public const String K_MAX_DOT_GRAPH_DEPTH = "MAX_DOT_GRAPH_DEPTH";    // = 0
        public const String K_DOT_TRANSPARENT = "DOT_TRANSPARENT";        // = NO
        public const String K_DOT_MULTI_TARGETS = "DOT_MULTI_TARGETS";      // = NO
        public const String K_GENERATE_LEGEND = "GENERATE_LEGEND";        // = YES
        public const String K_DOT_CLEANUP = "DOT_CLEANUP";            // = YES


        public const Int32 WM_NCLBUTTONDOWN = 0xA1;
        public const Int32 HT_CAPTION = 0x2;

        public const Int32 K_FirstRowReadable = 18;

        public const Int32 K_ColumnTag = 0;
        public const Int32 K_ColumnValue = 1;
        public const Int32 K_ColumnDescriptionHidden = 2;
        public const Int32 K_ColumnOriginalValue = 3;

        public const Int32 K_IndexTag = 0;
        public const Int32 K_IndexValue = 1;

        public const Int32 K_ColWidthFillUp = 50;

        public const String K_CharDescription = "#";
        public const String K_CharDescriptionAlt = "#-";
        public const String K_CharDivideKeyValue = "=";
        public const String K_ButtonText = "...";
        public const String K_DelimiterDescription = "#---------------------------------------------------------------------------";

        public const Int32 K_ColWidthTag = 350;

        public const Char K_ButtonEnterPressed = (Char)13;
    }
}
