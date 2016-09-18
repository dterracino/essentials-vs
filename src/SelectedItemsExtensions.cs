//using System;
//using System.Runtime.InteropServices;
//using EnvDTE;
//using VSLangProj;

//namespace YD.Framework.VisualStudio.SelectedItemsExtensions_
//{
//    using Packages;
//    using Solutions;
//    using ProjectItems.ProjectItemExtensions_;
//    using Microsoft.VisualStudio.Shell;
//    using Microsoft.VisualStudio.Shell.Interop;
//    using Luminous.Framework.VisualStudio.Solutions;

//    public static class SelectedItemsExtensions
//    {
//        //public static SolutionExplorerItemType GetSolutionExplorerItemType(this SelectedItems selectedItems)
//        //{
//        //    try
//        //    {
//        //        var dte = PackageBase.GetDte();
//        //        var count = selectedItems.Count;

//        //        if (count == 0)
//        //            return SolutionExplorerItemType.NoSelection;

//        //        if (count > 1)
//        //            return SolutionExplorerItemType.MultiSelection;

//        //        var selectedItem = selectedItems.Item(1);
//        //        var selectedItemName = selectedItem.Name;
//        //        var project = selectedItem.Project;
//        //        var projectItem = selectedItem.ProjectItem;

//        //        if (project == null || projectItem == null)
//        //            return SolutionExplorerItemType.Unknown;

//        //        var solutionExplorer = dte.ToolWindows.SolutionExplorer;

//        //        if (selectedItem is Project)
//        //        {
//        //            return SolutionExplorerItemType.Project;
//        //        }

//        //        if (selectedItem is Reference)
//        //        {
//        //            return SolutionExplorerItemType.Reference;
//        //        }

//        //        if (selectedItem is ProjectItem)
//        //        {
//        //            var selectedProjectItem = (selectedItem as ProjectItem);

//        //            if (selectedProjectItem == null)
//        //                return SolutionExplorerItemType.Unknown;

//        //            return selectedProjectItem.GetSolutionExplorerItemType();
//        //        }
//        //        return SolutionExplorerItemType.Unknown;
//        //    }
//        //    catch (Exception)
//        //    {
//        //        return SolutionExplorerItemType.Unknown;
//        //    }
//        //}

//        public static SolutionExplorerItemType GetCurrentSelectionKind(this SelectedItems selectedItems)
//        {
//            SolutionExplorerItemType kind;
//            try
//            {
//                if (selectedItems.Count > 1)
//                {
//                    kind = SolutionExplorerItemType.MultiSelection;
//                }
//                else if (selectedItems.Count >= 1)
//                {
//                    SelectedItem selectedItem = selectedItems.Item(1);
//                    Project project = selectedItem.Project;
//                    ProjectItem projectItem = selectedItem.ProjectItem;
//                    if (project != null || projectItem != null || string.IsNullOrEmpty(selectedItem.Name) || !selectedItem.Name.Equals("references", StringComparison.InvariantCultureIgnoreCase))
//                    {
//                        //UIHierarchy solutionExplorer = ServiceProvider.GlobalProvider.GetDte2().ToolWindows.SolutionExplorer;
//                        UIHierarchy solutionExplorer = PackageBase.GetDte().ToolWindows.SolutionExplorer;
//                        object obj = selectedItems.GetSelectedItem();
//                        if (obj == null)
//                        {
//                            if (selectedItems.Count != 1)
//                            {
//                                kind = SolutionExplorerItemType.Unknown;
//                            }
//                            else
//                            {
//                                SelectedItem selectedItem1 = selectedItems.Item(1);
//                                kind = (selectedItem1.Project != null || selectedItem1.ProjectItem != null ? SolutionExplorerItemType.Unknown : SolutionExplorerItemType.Solution);
//                            }
//                        }
//                        else if (obj is Project)
//                        {
//                            kind = (obj as Project).GetKind();
//                        }
//                        else if (obj is Reference)
//                        {
//                            kind = SolutionExplorerItemType.Reference;
//                        }
//                        else if (!(obj is ProjectItem))
//                        {
//                            return SolutionExplorerItemType.Unknown;
//                        }
//                        else
//                        {
//                            kind = (obj as ProjectItem).GetKind();
//                        }
//                    }
//                    else
//                    {
//                        kind = SolutionExplorerItemType.ReferenceRoot;
//                    }
//                }
//                else
//                {
//                    kind = SolutionExplorerItemType.NoSelection;
//                }
//            }
//            catch (Exception)
//            {
//                //exception.DiagnosticOnlyLog();
//                return SolutionExplorerItemType.Unknown;
//            }
//            return kind;
//        }

//        public static Project GetSelectedProject(this SelectedItems selectedItems)
//        {
//            object obj;
//            var vsHierarchyFromSelection = selectedItems.GetIVsHierarchyFromSelection();
//            var vsHeirarchy = vsHierarchyFromSelection.IVsHierarchy;

//            if (vsHeirarchy == null || vsHeirarchy.GetProperty(vsHierarchyFromSelection.HierarchyNodeId, -2027, out obj) != 0 || !(obj is Project))
//            {
//                throw new ArgumentException("Selected item is not a [EnvDTE.Project].");
//            }
//            return (Project)obj;
//        }

//        public static object GetSelectedItem(this SelectedItems selectedItems)
//        {
//            object obj;
//            IVSHierarchyNodeInfo vsHierarchyFromSelection = selectedItems.GetIVsHierarchyFromSelection();
//            if (vsHierarchyFromSelection == null)
//            {
//                return null;
//            }
//            if (vsHierarchyFromSelection.IVsHierarchy != null && vsHierarchyFromSelection.IVsHierarchy.GetProperty(vsHierarchyFromSelection.HierarchyNodeId, -2027, out obj) == 0)
//            {
//                return obj;
//            }
//            return null;
//        }

//        public static SolutionExplorerItemType GetKind(this Project project)
//        {
//            if (new Guid(project.Kind) == SolutionItemKind.ProjectAsSolutionFolder)
//            {
//                return SolutionExplorerItemType.SolutionFolder;
//            }
//            return SolutionExplorerItemType.Project;
//        }

//        public static SolutionExplorerItemType GetKind(this ProjectItem projectItem)
//        {
//            string lower = projectItem.Kind.ToLower();
//            string str = lower;
//            if (lower != null)
//            {
//                if (str == "{6bb5f8ef-4483-11d3-8bcf-00c04f8ec28c}")
//                {
//                    return SolutionExplorerItemType.Folder;
//                }
//                if (str == "{6bb5f8ee-4483-11d3-8bcf-00c04f8ec28c}")
//                {
//                    return SolutionExplorerItemType.File;
//                }
//                if (str == "{66a26722-8fb5-11d2-aa7e-00c04f688dde}")
//                {
//                    return SolutionExplorerItemType.SolutionFolder;
//                }
//            }
//            //Logger.TraceDiagnosticWarning(() => string.Concat("Unknown project item type: ", projectItem.Kind));
//            return SolutionExplorerItemType.Unknown;
//        }

//        public static IVSHierarchyNodeInfo GetIVsHierarchyFromSelection(this SelectedItems selectedItems)
//        {
//            IntPtr intPtr;
//            IntPtr intPtr1;
//            uint num;
//            IVsMultiItemSelect vsMultiItemSelect;
//            IVsHierarchy objectForIUnknown = null;
//            IVSHierarchyNodeInfo vSHierarchyNodeInfo = null;
//            if ((Package.GetGlobalService(typeof(IVsMonitorSelection)) as IVsMonitorSelection).GetCurrentSelection(out intPtr, out num, out vsMultiItemSelect, out intPtr1) == 0 && intPtr != IntPtr.Zero)
//            {
//                objectForIUnknown = Marshal.GetObjectForIUnknown(intPtr) as IVsHierarchy;
//                Marshal.Release(intPtr);
//                var vSHierarchyNodeInfo1 = new IVSHierarchyNodeInfo
//                {
//                    HierarchyNodeId = num,
//                    IVsHierarchy = objectForIUnknown
//                };
//                vSHierarchyNodeInfo = vSHierarchyNodeInfo1;
//            }
//            return vSHierarchyNodeInfo;
//        }

//        public class IVSHierarchyNodeInfo
//        {
//            public uint HierarchyNodeId { get; set; }

//            public IVsHierarchy IVsHierarchy { get; set; }
//        }
//    }
//}