<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to delete grid rows via the DeleteFocusedRow grid command


<p>The following example demonstrates how to add a <strong>Delete</strong> item to the grid cell's context menu.</p>


<h3>Description</h3>

<p>All this can be done completely in XAML. To solve this task, it is necessary to add the <strong>BarButtonItem</strong> element to the <strong>TableView.RowCellMenuCustomizations</strong> collection, and set the <strong>GridCommands.DeleteFocusedRow</strong> value to its <strong>Command</strong> property.</p>

<br/>


