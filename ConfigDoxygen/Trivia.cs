/*
ConfigDoxyGen - An humble GUI front-end for editing configure doxygen files.
Copyright (c) 2019 Francesco Paolo Lezza (francescoprogrammer.com)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which contains some bored statements...
    /// </summary>
    public static class Trivia {

        /// <summary>
        /// This method fill into four list objects some items: button, combo, opendialogbox, inputbox.
        /// </summary>
        /// <param name="ls1">Represents a list object about button object.</param>
        /// <param name="ls2">Represents a list object about combo object.</param>
        /// <param name="ls3">Represents a list object about opendialogbox object.</param>
        /// <param name="ls4">Represents a list object about inputbox object.</param>
        /// <param name="ls5">Represents a list object about checkboxitem object.</param>
        public static void SetListsInForm(ref List<String> ls1, ref List<String> ls2,
                                          ref List<String> ls3, ref List<String> ls4, 
                                          ref List<String> ls5) {
            //populate button column
            ls1.Add(Constants.K_ALIASES);
            ls1.Add(Constants.K_CHM_FILE);
            ls1.Add(Constants.K_CHM_INDEX_ENCODING);
            ls1.Add(Constants.K_CITE_BIB_FILES);
            ls1.Add(Constants.K_DIAFILE_DIRS);
            ls1.Add(Constants.K_DIA_PATH);
            ls1.Add(Constants.K_DOCSET_BUNDLE_ID);
            ls1.Add(Constants.K_DOCSET_FEEDNAME);
            ls1.Add(Constants.K_DOCSET_PUBLISHER_ID);
            ls1.Add(Constants.K_DOCSET_PUBLISHER_NAME);
            ls1.Add(Constants.K_DOTFILE_DIRS);
            ls1.Add(Constants.K_DOT_FONTPATH);
            ls1.Add(Constants.K_DOT_PATH);
            ls1.Add(Constants.K_ECLIPSE_DOC_ID);
            ls1.Add(Constants.K_ENABLED_SECTIONS);
            ls1.Add(Constants.K_EXAMPLE_PATH);
            ls1.Add(Constants.K_EXAMPLE_PATTERNS);
            ls1.Add(Constants.K_EXCLUDE);
            ls1.Add(Constants.K_EXCLUDE_PATTERNS);
            ls1.Add(Constants.K_EXCLUDE_SYMBOLS);
            ls1.Add(Constants.K_EXPAND_AS_DEFINED);
            ls1.Add(Constants.K_EXTERNAL_SEARCH_ID);
            ls1.Add(Constants.K_EXTRA_PACKAGES);
            ls1.Add(Constants.K_EXTRA_SEARCH_MAPPINGS);
            ls1.Add(Constants.K_FILE_VERSION_FILTER);
            ls1.Add(Constants.K_FILTER_PATTERNS);
            ls1.Add(Constants.K_FILTER_SOURCE_PATTERNS);
            ls1.Add(Constants.K_GENERATE_TAGFILE);
            ls1.Add(Constants.K_HHC_LOCATION);
            ls1.Add(Constants.K_HTML_EXTRA_FILES);
            ls1.Add(Constants.K_HTML_EXTRA_STYLESHEET);
            ls1.Add(Constants.K_HTML_FILE_EXTENSION);
            ls1.Add(Constants.K_HTML_FOOTER);
            ls1.Add(Constants.K_HTML_HEADER);
            ls1.Add(Constants.K_HTML_OUTPUT);
            ls1.Add(Constants.K_HTML_STYLESHEET);
            ls1.Add(Constants.K_IGNORE_PREFIX);
            ls1.Add(Constants.K_IMAGE_PATH);
            ls1.Add(Constants.K_INCLUDE_FILE_PATTERNS);
            ls1.Add(Constants.K_INCLUDE_PATH);
            ls1.Add(Constants.K_INPUT);
            ls1.Add(Constants.K_INPUT_FILTER);
            ls1.Add(Constants.K_LATEX_BIB_STYLE);
            ls1.Add(Constants.K_LATEX_CMD_NAME);
            ls1.Add(Constants.K_LATEX_EXTRA_FILES);
            ls1.Add(Constants.K_LATEX_FOOTER);
            ls1.Add(Constants.K_LATEX_HEADER);
            ls1.Add(Constants.K_LATEX_OUTPUT);
            ls1.Add(Constants.K_LAYOUT_FILE);
            ls1.Add(Constants.K_MAKEINDEX_CMD_NAME);
            ls1.Add(Constants.K_MAN_OUTPUT);
            ls1.Add(Constants.K_MAN_SUBDIR);
            ls1.Add(Constants.K_MATHJAX_CODEFILE);
            ls1.Add(Constants.K_MATHJAX_EXTENSIONS);
            ls1.Add(Constants.K_MATHJAX_FORMAT);
            ls1.Add(Constants.K_MATHJAX_RELPATH);
            ls1.Add(Constants.K_MSCFILE_DIRS);
            ls1.Add(Constants.K_MSCGEN_PATH);
            ls1.Add(Constants.K_OUTPUT_DIRECTORY);
            ls1.Add(Constants.K_PERLMOD_MAKEVAR_PREFIX);
            ls1.Add(Constants.K_PERL_PATH);
            ls1.Add(Constants.K_PLANTUML_INCLUDE_PATH);
            ls1.Add(Constants.K_PLANTUML_JAR_PATH);
            ls1.Add(Constants.K_PREDEFINED);
            ls1.Add(Constants.K_PROJECT_BRIEF);
            ls1.Add(Constants.K_PROJECT_LOGO);
            ls1.Add(Constants.K_PROJECT_NAME);
            ls1.Add(Constants.K_PROJECT_NUMBER);
            ls1.Add(Constants.K_QHG_LOCATION);
            ls1.Add(Constants.K_QHP_CUST_FILTER_ATTRS);
            ls1.Add(Constants.K_QHP_CUST_FILTER_NAME);
            ls1.Add(Constants.K_QHP_NAMESPACE);
            ls1.Add(Constants.K_QHP_SECT_FILTER_ATTRS);
            ls1.Add(Constants.K_RTF_EXTENSIONS_FILE);
            ls1.Add(Constants.K_RTF_STYLESHEET_FILE);
            ls1.Add(Constants.K_SEARCHDATA_FILE);
            ls1.Add(Constants.K_SEARCHENGINE_URL);
            ls1.Add(Constants.K_STRIP_FROM_INC_PATH);
            ls1.Add(Constants.K_STRIP_FROM_PATH);
            ls1.Add(Constants.K_TAGFILES);
            ls1.Add(Constants.K_TCL_SUBST);
            ls1.Add(Constants.K_USE_MDFILE_AS_MAINPAGE);
            ls1.Add(Constants.K_WARN_FORMAT);
            ls1.Add(Constants.K_WARN_LOGFILE);
            ls1.Add(Constants.K_XML_OUTPUT);


            //populate combo column
            ls2.Add(Constants.K_ALLEXTERNALS);
            ls2.Add(Constants.K_ALLOW_UNICODE_NAMES);
            ls2.Add(Constants.K_ALPHABETICAL_INDEX);
            ls2.Add(Constants.K_ALWAYS_DETAILED_SEC);
            ls2.Add(Constants.K_AUTOLINK_SUPPORT);
            ls2.Add(Constants.K_BINARY_TOC);
            ls2.Add(Constants.K_BRIEF_MEMBER_DESC);
            ls2.Add(Constants.K_BUILTIN_STL_SUPPORT);
            ls2.Add(Constants.K_CALLER_GRAPH);
            ls2.Add(Constants.K_CALL_GRAPH);
            ls2.Add(Constants.K_CASE_SENSE_NAMES);
            ls2.Add(Constants.K_CLASS_DIAGRAMS);
            ls2.Add(Constants.K_CLASS_GRAPH);
            ls2.Add(Constants.K_COLLABORATION_GRAPH);
            ls2.Add(Constants.K_COLS_IN_ALPHA_INDEX);
            ls2.Add(Constants.K_COMPACT_LATEX);
            ls2.Add(Constants.K_COMPACT_RTF);
            ls2.Add(Constants.K_CPP_CLI_SUPPORT);
            ls2.Add(Constants.K_CREATE_SUBDIRS);
            ls2.Add(Constants.K_DIRECTORY_GRAPH);
            ls2.Add(Constants.K_DISABLE_INDEX);
            ls2.Add(Constants.K_DISTRIBUTE_GROUP_DOC);
            ls2.Add(Constants.K_DOCBOOK_PROGRAMLISTING);
            ls2.Add(Constants.K_DOT_CLEANUP);
            ls2.Add(Constants.K_DOT_FONTNAME);
            ls2.Add(Constants.K_DOT_FONTSIZE);
            ls2.Add(Constants.K_DOT_IMAGE_FORMAT);
            ls2.Add(Constants.K_DOT_GRAPH_MAX_NODES);
            ls2.Add(Constants.K_DOT_NUM_THREADS);
            ls2.Add(Constants.K_DOT_MULTI_TARGETS);
            ls2.Add(Constants.K_DOT_TRANSPARENT);
            ls2.Add(Constants.K_DOXYFILE_ENCODING);
            ls2.Add(Constants.K_ENABLE_PREPROCESSING);
            ls2.Add(Constants.K_EXAMPLE_RECURSIVE);
            ls2.Add(Constants.K_ENUM_VALUES_PER_LINE);
            ls2.Add(Constants.K_EXCLUDE_SYMLINKS);
            ls2.Add(Constants.K_EXPAND_ONLY_PREDEF);
            ls2.Add(Constants.K_EXTERNAL_GROUPS);
            ls2.Add(Constants.K_EXTERNAL_PAGES);
            ls2.Add(Constants.K_EXTERNAL_SEARCH);
            ls2.Add(Constants.K_EXTRACT_ALL);
            ls2.Add(Constants.K_EXTRACT_ANON_NSPACES);
            ls2.Add(Constants.K_EXTRACT_LOCAL_CLASSES);
            ls2.Add(Constants.K_EXTRACT_LOCAL_METHODS);
            ls2.Add(Constants.K_EXTRACT_PACKAGE);
            ls2.Add(Constants.K_EXTRACT_PRIVATE);
            ls2.Add(Constants.K_EXTRACT_STATIC);
            ls2.Add(Constants.K_EXT_LINKS_IN_WINDOW);
            ls2.Add(Constants.K_FILTER_SOURCE_FILES);
            ls2.Add(Constants.K_FORCE_LOCAL_INCLUDES);
            ls2.Add(Constants.K_FORMULA_FONTSIZE);
            ls2.Add(Constants.K_FORMULA_TRANSPARENT);
            ls2.Add(Constants.K_FULL_PATH_NAMES);
            ls2.Add(Constants.K_GENERATE_AUTOGEN_DEF);
            ls2.Add(Constants.K_GENERATE_BUGLIST);
            ls2.Add(Constants.K_GENERATE_CHI);
            ls2.Add(Constants.K_GENERATE_DEPRECATEDLIST);
            ls2.Add(Constants.K_GENERATE_DOCBOOK);
            ls2.Add(Constants.K_GENERATE_DOCSET);
            ls2.Add(Constants.K_GENERATE_ECLIPSEHELP);
            ls2.Add(Constants.K_GENERATE_HTML);
            ls2.Add(Constants.K_GENERATE_HTMLHELP);
            ls2.Add(Constants.K_GENERATE_LATEX);
            ls2.Add(Constants.K_GENERATE_LEGEND);
            ls2.Add(Constants.K_GENERATE_MAN);
            ls2.Add(Constants.K_GENERATE_PERLMOD);
            ls2.Add(Constants.K_GENERATE_QHP);
            ls2.Add(Constants.K_GENERATE_RTF);
            ls2.Add(Constants.K_GENERATE_TESTLIST);
            ls2.Add(Constants.K_GENERATE_TODOLIST);
            ls2.Add(Constants.K_GENERATE_TREEVIEW);
            ls2.Add(Constants.K_GENERATE_XML);
            ls2.Add(Constants.K_GRAPHICAL_HIERARCHY);
            ls2.Add(Constants.K_GROUP_GRAPHS);
            ls2.Add(Constants.K_HAVE_DOT);
            ls2.Add(Constants.K_HTML_COLORSTYLE_HUE);
            ls2.Add(Constants.K_HTML_COLORSTYLE_SAT);
            ls2.Add(Constants.K_HTML_COLORSTYLE_GAMMA);
            ls2.Add(Constants.K_HIDE_COMPOUND_REFERENCE);
            ls2.Add(Constants.K_HIDE_FRIEND_COMPOUNDS);
            ls2.Add(Constants.K_HIDE_IN_BODY_DOCS);
            ls2.Add(Constants.K_HTML_INDEX_NUM_ENTRIES);
            ls2.Add(Constants.K_HIDE_SCOPE_NAMES);
            ls2.Add(Constants.K_HIDE_UNDOC_CLASSES);
            ls2.Add(Constants.K_HIDE_UNDOC_MEMBERS);
            ls2.Add(Constants.K_HIDE_UNDOC_RELATIONS);
            ls2.Add(Constants.K_HTML_DYNAMIC_SECTIONS);
            ls2.Add(Constants.K_HTML_TIMESTAMP);
            ls2.Add(Constants.K_IDL_PROPERTY_SUPPORT);
            ls2.Add(Constants.K_INCLUDED_BY_GRAPH);
            ls2.Add(Constants.K_INCLUDE_GRAPH);
            ls2.Add(Constants.K_INHERIT_DOCS);
            ls2.Add(Constants.K_INLINE_GROUPED_CLASSES);
            ls2.Add(Constants.K_INLINE_INFO);
            ls2.Add(Constants.K_INLINE_INHERITED_MEMB);
            ls2.Add(Constants.K_INLINE_SIMPLE_STRUCTS);
            ls2.Add(Constants.K_INLINE_SOURCES);
            ls2.Add(Constants.K_INPUT_ENCODING);
            ls2.Add(Constants.K_INTERACTIVE_SVG);
            ls2.Add(Constants.K_INTERNAL_DOCS);
            ls2.Add(Constants.K_JAVADOC_AUTOBRIEF);
            ls2.Add(Constants.K_LATEX_BATCHMODE);
            ls2.Add(Constants.K_LATEX_BIB_STYLE);
            ls2.Add(Constants.K_LATEX_HIDE_INDICES);
            ls2.Add(Constants.K_LATEX_SOURCE_CODE);
            ls2.Add(Constants.K_LOOKUP_CACHE_SIZE);
            ls2.Add(Constants.K_MACRO_EXPANSION);
            ls2.Add(Constants.K_MAN_LINKS);
            ls2.Add(Constants.K_MARKDOWN_SUPPORT);
            ls2.Add(Constants.K_MAX_DOT_GRAPH_DEPTH);
            ls2.Add(Constants.K_MAX_INITIALIZER_LINES);
            ls2.Add(Constants.K_MULTILINE_CPP_IS_BRIEF);
            ls2.Add(Constants.K_OPTIMIZE_FOR_FORTRAN);
            ls2.Add(Constants.K_OPTIMIZE_OUTPUT_FOR_C);
            ls2.Add(Constants.K_OPTIMIZE_OUTPUT_JAVA);
            ls2.Add(Constants.K_OPTIMIZE_OUTPUT_VHDL);
            ls2.Add(Constants.K_OUTPUT_LANGUAGE);
            ls2.Add(Constants.K_PAPER_TYPE);
            ls2.Add(Constants.K_PDF_HYPERLINKS);
            ls2.Add(Constants.K_PERLMOD_LATEX);
            ls2.Add(Constants.K_PERLMOD_PRETTY);
            ls2.Add(Constants.K_QT_AUTOBRIEF);
            ls2.Add(Constants.K_QUIET);
            ls2.Add(Constants.K_RECURSIVE);
            ls2.Add(Constants.K_REFERENCED_BY_RELATION);
            ls2.Add(Constants.K_REFERENCES_LINK_SOURCE);
            ls2.Add(Constants.K_REFERENCES_RELATION);
            ls2.Add(Constants.K_REPEAT_BRIEF);
            ls2.Add(Constants.K_RTF_HYPERLINKS);
            ls2.Add(Constants.K_SEARCHENGINE);
            ls2.Add(Constants.K_SEARCH_INCLUDES);
            ls2.Add(Constants.K_SEPARATE_MEMBER_PAGES);
            ls2.Add(Constants.K_SERVER_BASED_SEARCH);
            ls2.Add(Constants.K_SHORT_NAMES);
            ls2.Add(Constants.K_SHOW_FILES);
            ls2.Add(Constants.K_SHOW_GROUPED_MEMB_INC);
            ls2.Add(Constants.K_SHOW_INCLUDE_FILES);
            ls2.Add(Constants.K_SHOW_NAMESPACES);
            ls2.Add(Constants.K_SHOW_USED_FILES);
            ls2.Add(Constants.K_SIP_SUPPORT);
            ls2.Add(Constants.K_SKIP_FUNCTION_MACROS);
            ls2.Add(Constants.K_SORT_BRIEF_DOCS);
            ls2.Add(Constants.K_SORT_BY_SCOPE_NAME);
            ls2.Add(Constants.K_SORT_GROUP_NAMES);
            ls2.Add(Constants.K_SORT_MEMBERS_CTORS_1ST);
            ls2.Add(Constants.K_SORT_MEMBER_DOCS);
            ls2.Add(Constants.K_SOURCE_BROWSER);
            ls2.Add(Constants.K_SOURCE_TOOLTIPS);
            ls2.Add(Constants.K_STRICT_PROTO_MATCHING);
            ls2.Add(Constants.K_STRIP_CODE_COMMENTS);
            ls2.Add(Constants.K_SUBGROUPING);
            ls2.Add(Constants.K_TAB_SIZE);
            ls2.Add(Constants.K_TEMPLATE_RELATIONS);
            ls2.Add(Constants.K_TOC_EXPAND);
            ls2.Add(Constants.K_TREEVIEW_WIDTH);
            ls2.Add(Constants.K_TYPEDEF_HIDES_STRUCT);
            ls2.Add(Constants.K_UML_LOOK);
            ls2.Add(Constants.K_UML_LIMIT_NUM_FIELDS);
            ls2.Add(Constants.K_USE_HTAGS);
            ls2.Add(Constants.K_USE_MATHJAX);
            ls2.Add(Constants.K_USE_PDFLATEX);
            ls2.Add(Constants.K_VERBATIM_HEADERS);
            ls2.Add(Constants.K_WARNINGS);
            ls2.Add(Constants.K_WARN_IF_DOC_ERROR);
            ls2.Add(Constants.K_WARN_IF_UNDOCUMENTED);
            ls2.Add(Constants.K_WARN_NO_PARAMDOC);
            ls2.Add(Constants.K_XML_PROGRAMLISTING);
            
            //button? ok, but what kind of?
            ls3.Add(Constants.K_OUTPUT_DIRECTORY);                     // --> opendialogbox
            ls3.Add(Constants.K_INPUT);                                // --> opendialogbox

            ls4.Add(Constants.K_PROJECT_NAME);                         // --> InputBox.cs
            ls4.Add(Constants.K_PROJECT_NUMBER);                       // --> InputBox.cs
            ls4.Add(Constants.K_PROJECT_BRIEF);                        // --> InputBox.cs
            ls4.Add(Constants.K_PROJECT_LOGO);                         // --> InputBox.cs
            ls4.Add(Constants.K_WARN_FORMAT);                          // --> InputBox.cs
            ls4.Add(Constants.K_HTML_COLORSTYLE_HUE);                  // --> InputBox.cs
            ls4.Add(Constants.K_HTML_COLORSTYLE_SAT);                  // --> InputBox.cs
            ls4.Add(Constants.K_HTML_COLORSTYLE_GAMMA);                // --> InputBox.cs
            ls4.Add(Constants.K_HTML_INDEX_NUM_ENTRIES);               // --> InputBox.cs
            ls4.Add(Constants.K_DOCSET_FEEDNAME);                      // --> InputBox.cs
            ls4.Add(Constants.K_DOCSET_BUNDLE_ID);                     // --> InputBox.cs
            ls4.Add(Constants.K_DOCSET_PUBLISHER_ID);                  // --> InputBox.cs
            ls4.Add(Constants.K_QHP_NAMESPACE);                        // --> InputBox.cs
            ls4.Add(Constants.K_ECLIPSE_DOC_ID);                       // --> InputBox.cs
            ls4.Add(Constants.K_MATHJAX_RELPATH);                      // --> InputBox.cs
            ls4.Add(Constants.K_SEARCHDATA_FILE);                      // --> InputBox.cs
            ls4.Add(Constants.K_PERL_PATH);                            // --> InputBox.cs

            //checklistboxitem
            ls5.Add(Constants.K_FILE_PATTERNS);
            ls5.Add(Constants.K_ABBREVIATE_BRIEF);
        }

        /// <summary>
        /// This method decides if a particular tag is about yes/no combobox or not.
        /// 
        /// See: https://stackoverflow.com/questions/3907299/if-statements-matching-multiple-values
        /// </summary>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <returns>Returns true/false depending if tag is about yes/no combo or not. </returns>
        public static Boolean TestingYesNoCombo(String tag) {
            return tag.In(Constants.K_ALLEXTERNALS, Constants.K_ALLOW_UNICODE_NAMES, Constants.K_ALPHABETICAL_INDEX, Constants.K_ALWAYS_DETAILED_SEC,
                          Constants.K_AUTOLINK_SUPPORT, Constants.K_BINARY_TOC, Constants.K_BRIEF_MEMBER_DESC, Constants.K_BUILTIN_STL_SUPPORT,
                          Constants.K_CALLER_GRAPH, Constants.K_CALL_GRAPH, Constants.K_CASE_SENSE_NAMES, Constants.K_CLASS_DIAGRAMS, Constants.K_CLASS_GRAPH,
                          Constants.K_COLLABORATION_GRAPH, Constants.K_COMPACT_LATEX, Constants.K_COMPACT_RTF, Constants.K_CPP_CLI_SUPPORT, Constants.K_CREATE_SUBDIRS,
                          Constants.K_DIRECTORY_GRAPH, Constants.K_DISABLE_INDEX, Constants.K_DISTRIBUTE_GROUP_DOC, Constants.K_DOCBOOK_PROGRAMLISTING, Constants.K_DOT_CLEANUP,
                          Constants.K_DOT_MULTI_TARGETS, Constants.K_DOT_TRANSPARENT, Constants.K_ENABLE_PREPROCESSING, Constants.K_EXAMPLE_RECURSIVE, Constants.K_EXCLUDE_SYMLINKS,
                          Constants.K_EXPAND_ONLY_PREDEF, Constants.K_EXTERNAL_GROUPS, Constants.K_EXTERNAL_PAGES, Constants.K_EXTERNAL_SEARCH, Constants.K_EXTRACT_ALL,
                          Constants.K_EXTRACT_ANON_NSPACES, Constants.K_EXTRACT_LOCAL_CLASSES, Constants.K_EXTRACT_LOCAL_METHODS, Constants.K_EXTRACT_PACKAGE, Constants.K_EXTRACT_PRIVATE,
                          Constants.K_EXTRACT_STATIC, Constants.K_EXT_LINKS_IN_WINDOW, Constants.K_FILTER_SOURCE_FILES, Constants.K_FORCE_LOCAL_INCLUDES, Constants.K_FORMULA_TRANSPARENT,
                          Constants.K_FULL_PATH_NAMES, Constants.K_GENERATE_AUTOGEN_DEF, Constants.K_GENERATE_BUGLIST, Constants.K_GENERATE_CHI, Constants.K_GENERATE_DEPRECATEDLIST,
                          Constants.K_GENERATE_DOCBOOK, Constants.K_GENERATE_DOCSET, Constants.K_GENERATE_ECLIPSEHELP, Constants.K_GENERATE_HTML, Constants.K_GENERATE_HTMLHELP,
                          Constants.K_GENERATE_LATEX, Constants.K_GENERATE_LEGEND, Constants.K_GENERATE_MAN, Constants.K_GENERATE_PERLMOD, Constants.K_GENERATE_QHP, Constants.K_GENERATE_RTF,
                          Constants.K_GENERATE_TESTLIST, Constants.K_GENERATE_TODOLIST, Constants.K_GENERATE_TREEVIEW, Constants.K_GENERATE_XML, Constants.K_GRAPHICAL_HIERARCHY,
                          Constants.K_GROUP_GRAPHS, Constants.K_HAVE_DOT, Constants.K_HIDE_COMPOUND_REFERENCE, Constants.K_HIDE_FRIEND_COMPOUNDS, Constants.K_HIDE_IN_BODY_DOCS, Constants.K_HIDE_SCOPE_NAMES,
                          Constants.K_HIDE_UNDOC_CLASSES, Constants.K_HIDE_UNDOC_MEMBERS, Constants.K_HIDE_UNDOC_RELATIONS, Constants.K_HTML_DYNAMIC_SECTIONS, Constants.K_HTML_TIMESTAMP,
                          Constants.K_IDL_PROPERTY_SUPPORT, Constants.K_INCLUDED_BY_GRAPH, Constants.K_INCLUDE_GRAPH, Constants.K_INHERIT_DOCS, Constants.K_INLINE_GROUPED_CLASSES,
                          Constants.K_INLINE_INFO, Constants.K_INLINE_INHERITED_MEMB, Constants.K_INLINE_SIMPLE_STRUCTS, Constants.K_INLINE_SOURCES, Constants.K_INTERACTIVE_SVG,
                          Constants.K_INTERNAL_DOCS, Constants.K_JAVADOC_AUTOBRIEF, Constants.K_LATEX_BATCHMODE, Constants.K_LATEX_BIB_STYLE, Constants.K_LATEX_HIDE_INDICES, Constants.K_LATEX_SOURCE_CODE,
                          Constants.K_MACRO_EXPANSION, Constants.K_MAN_LINKS, Constants.K_MARKDOWN_SUPPORT, Constants.K_MULTILINE_CPP_IS_BRIEF, Constants.K_OPTIMIZE_FOR_FORTRAN,
                          Constants.K_OPTIMIZE_OUTPUT_FOR_C, Constants.K_OPTIMIZE_OUTPUT_JAVA, Constants.K_OPTIMIZE_OUTPUT_VHDL, Constants.K_PDF_HYPERLINKS, Constants.K_PERLMOD_LATEX,
                          Constants.K_PERLMOD_PRETTY, Constants.K_QT_AUTOBRIEF, Constants.K_QUIET, Constants.K_RECURSIVE, Constants.K_REFERENCED_BY_RELATION, Constants.K_REFERENCES_LINK_SOURCE,
                          Constants.K_REFERENCES_RELATION, Constants.K_REPEAT_BRIEF, Constants.K_RTF_HYPERLINKS, Constants.K_SEARCHENGINE, Constants.K_SEARCH_INCLUDES, Constants.K_SEPARATE_MEMBER_PAGES,
                          Constants.K_SERVER_BASED_SEARCH, Constants.K_SHORT_NAMES, Constants.K_SHOW_FILES, Constants.K_SHOW_GROUPED_MEMB_INC, Constants.K_SHOW_INCLUDE_FILES, Constants.K_SHOW_NAMESPACES,
                          Constants.K_SHOW_USED_FILES, Constants.K_SIP_SUPPORT, Constants.K_SKIP_FUNCTION_MACROS, Constants.K_SORT_BRIEF_DOCS, Constants.K_SORT_BY_SCOPE_NAME, Constants.K_SORT_GROUP_NAMES,
                          Constants.K_SORT_MEMBERS_CTORS_1ST, Constants.K_SORT_MEMBER_DOCS, Constants.K_SOURCE_BROWSER, Constants.K_SOURCE_TOOLTIPS, Constants.K_STRICT_PROTO_MATCHING,
                          Constants.K_STRIP_CODE_COMMENTS, Constants.K_SUBGROUPING, Constants.K_TEMPLATE_RELATIONS, Constants.K_TOC_EXPAND, Constants.K_TYPEDEF_HIDES_STRUCT, Constants.K_UML_LOOK,
                          Constants.K_USE_HTAGS, Constants.K_USE_MATHJAX, Constants.K_USE_PDFLATEX, Constants.K_VERBATIM_HEADERS, Constants.K_WARNINGS, Constants.K_WARN_IF_DOC_ERROR, Constants.K_WARN_IF_UNDOCUMENTED,
                          Constants.K_WARN_NO_PARAMDOC, Constants.K_XML_PROGRAMLISTING);
        }

        /// <summary>
        /// This method decides if a particular tag contains in its description any dot line rox (#---------).
        /// </summary>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <returns>Returns true/false depending on description tag contains any dot line.</returns>
        public static Boolean TestingDotLineDescription(String tag) {
            return tag.In(Constants.K_EXTRACT_ALL, Constants.K_QUIET, Constants.K_INPUT, Constants.K_SOURCE_BROWSER, Constants.K_ALPHABETICAL_INDEX, Constants.K_GENERATE_HTML, Constants.K_GENERATE_LATEX,
                          Constants.K_GENERATE_RTF, Constants.K_GENERATE_MAN, Constants.K_GENERATE_XML, Constants.K_GENERATE_DOCBOOK, Constants.K_GENERATE_AUTOGEN_DEF, Constants.K_GENERATE_PERLMOD,
                          Constants.K_ENABLE_PREPROCESSING, Constants.K_TAGFILES, Constants.K_CLASS_DIAGRAMS);
        }

        /// <summary>
        /// This method represents if a particular tag contains in its description any quote character.
        /// </summary>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <returns>Returns true/false depending on description tag contains any quete character.</returns>
        public static Boolean TestingQuoteValue(String tag) {
            return tag.In(Constants.K_PROJECT_NAME, Constants.K_PROJECT_NUMBER, Constants.K_PROJECT_BRIEF, Constants.K_OUTPUT_DIRECTORY,
                          Constants.K_WARN_FORMAT, Constants.K_INPUT, Constants.K_DOCSET_FEEDNAME);
        }

        /// <summary>
        /// This method customize a particular tag related on combobox object.
        /// 
        /// See: https://stackoverflow.com/questions/3907299/if-statements-matching-multiple-values
        /// </summary>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <returns>Returns true/false depending on if tag is repated on custom combobox object.</returns>
        public static String[] Combo_Other(String tag) {
            switch (tag) {
                case Constants.K_COLS_IN_ALPHA_INDEX:
                    return StringUtils.GetArrayStringValuesByRange(1, 20);
                case Constants.K_DOT_FONTNAME:
                    return new String[] { "Arial", "Helvetica", "sans-serif", "serif", "Times", "Times New Roman", "Verdana" };
                case Constants.K_DOT_FONTSIZE:
                    return StringUtils.GetArrayStringValuesByRange(4, 24);
                case Constants.K_DOT_GRAPH_MAX_NODES:
                    return StringUtils.GetArrayStringValuesByRange(0, 10000);
                case Constants.K_DOT_IMAGE_FORMAT:
                    return new String[] { "gif", "jpg", "png", "svg" };
                case Constants.K_DOT_NUM_THREADS:
                    return StringUtils.GetArrayStringValuesByRange(0, 32);
                case Constants.K_DOXYFILE_ENCODING:
                    return new String[] { "UTF-8", "UTF-16", "UTF-32" };
                case Constants.K_ENUM_VALUES_PER_LINE:
                    return StringUtils.GetArrayStringValuesByRange(0, 20);
                case Constants.K_FILE_PATTERNS:
                    return new String[] { "*.as ", "*.c", "*.c++", "*.cc", "*.cpp", "*.cs", "*.cxx", "*.d", "*.ddl", "*.dox",
                                          "*.f", "*.f90", "*.for", "*.h", "*.h++", "*.hh", "*.hpp", "*.hxx", "*.i++", "*.idl",
                                          "*.ii", "*.inc", "*.inl", "*.ipp", "*.ixx", "*.java", "*.js.", "*.m", "*.markdown", 
                                          "*.md", "*.mm", "*.odl", "*.php", "*.php4", "*.php5", "*.phtml", "*.py", "*.qsf",
                                          "*.tcl", "*.ucf", "*.vhd", "*.vhdl" };
                case Constants.K_FORMULA_FONTSIZE:
                    return StringUtils.GetArrayStringValuesByRange(8, 50);
                case Constants.K_HTML_COLORSTYLE_GAMMA:
                    return StringUtils.GetArrayStringValuesByRange(40, 240);
                case Constants.K_HTML_COLORSTYLE_HUE:
                    return StringUtils.GetArrayStringValuesByRange(0, 359);
                case Constants.K_HTML_COLORSTYLE_SAT:
                    return StringUtils.GetArrayStringValuesByRange(0, 255);
                case Constants.K_HTML_INDEX_NUM_ENTRIES:
                    return StringUtils.GetArrayStringValuesByRange(0, 9999);
                case Constants.K_INPUT_ENCODING:
                    //see: http://www.gnu.org/software/libiconv for the list of possible encodings
                    return new String[] { "C99", "JAVA", "UCS-2", "UCS-2BE", "UCS-2LE", "UCS-4", "UCS-4BE", 
                                          "UCS-4LE", "UTF-16", "UTF-16BE", "UTF-16LE", "UTF-32", "UTF-32BE",
                                          "UTF-32LE", "UTF-7", "UTF-8" };
                case Constants.K_LOOKUP_CACHE_SIZE:
                    return StringUtils.GetArrayStringValuesByRange(0, 9);
                case Constants.K_MAX_DOT_GRAPH_DEPTH:
                    return StringUtils.GetArrayStringValuesByRange(0, 1000);
                case Constants.K_MAX_INITIALIZER_LINES:
                    return StringUtils.GetArrayStringValuesByRange(0, 10000);
                case Constants.K_OUTPUT_LANGUAGE:
                    return new String[] { "Afrikaans", "Arabic", "Armenian", "Brazilian", "Catalan", "Chinese", "Chinese-Traditional",
                                          "Croatian", "Czech", "Danish", "Dutch", "English", "Esperanto", "Farsi",
                                          "Finnish", "French", "German", "Greek", "Hungarian", "Indonesian", "Italian", "Japanese", 
                                          "Japanese-en", "Korean", "Korean-en", "Latvian", "Lithuanian", "Macedonian", "Norwegian", 
                                          "Persian", "Polish", "Portuguese", "Romanian", "Russian", "Serbian", "Serbian-Cyrillic", 
                                          "Slovak", "Slovene", "Spanish", "Swedish", "Turkish", "Ukrainian", "Vietnamese" };
                case Constants.K_PAPER_TYPE:
                    return new String[] { "a4", "executive", "legal", "letter" };
                case Constants.K_TAB_SIZE:
                    return StringUtils.GetArrayStringValuesByRange(1, 16);
                case Constants.K_TREEVIEW_WIDTH:
                    return StringUtils.GetArrayStringValuesByRange(0, 1500);
                case Constants.K_UML_LIMIT_NUM_FIELDS:
                    return StringUtils.GetArrayStringValuesByRange(0, 100);
                default:
                    return new String[] { "In progress..." };
            }
        }

        /// <summary>
        /// This method set a DataGridViewComboBoxCell object, based on its tag. 
        /// </summary>
        /// <param name="cb">Represents a DataGridViewComboBoxCell object.</param>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <param name="value">Represents the tag value.</param>
        public static void FillCombo(ref DataGridViewComboBoxCell cb, String tag) {
            cb.ReadOnly = false;
            if (Trivia.TestingYesNoCombo(tag)) {
                cb.DataSource = new String[] { "YES", "NO" };
            } else {
                cb.DataSource = Trivia.Combo_Other(tag);
            }
        }

        /// <summary>
        /// This method verify if a particular cell shoud be modified into a button object.
        /// </summary>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <param name="ls">Represents a refence list of tags.</param>
        /// <returns>Returns true/false depending on input tag.</returns>
        public static Boolean VerifyTypeCellButton(String tag, ref List<String> ls) {
            foreach (String str in ls) {
                if (str == tag) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method verify if a particular cell shoud be modified into a Combobox object.
        /// </summary>
        /// <param name="tag">Represents a particular tag to test.</param>
        /// <param name="ls">Represents a refence list of tags.</param>
        /// <returns>Returns true/false depending on input tag.</returns>
        public static Boolean VerifyTypeCellCombo(String tag, ref List<String> ls) {
            foreach (String str in ls) {
                if (str == tag) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method iterate over a list object to know if a particular value is present or not.
        /// </summary>
        /// <param name="ListIteratable">Represent a list object over iterate.</param>
        /// <param name="Value">Represents a particular value to test.</param>
        /// <returns>Returns true/false depending on input value is present in a list object or not.</returns>
        public static Boolean IterateOverList(List<String> ListIteratable, String Value) {
            foreach (String item in ListIteratable) {
                if (item == Value) return true;
            }

            return false;
        }
    }
}
