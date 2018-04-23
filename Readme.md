# How to delete grid rows via the DeleteFocusedRow grid command


<p>The following example demonstrates how to add a <strong>Delete</strong> item to the grid cell's context menu.</p>


<h3>Description</h3>

<p>All this can be done completely in XAML. To solve this task, it is necessary to add the <strong>BarButtonItem</strong> element to the <strong>TableView.RowCellMenuCustomizations</strong> collection, and set the <strong>GridCommands.DeleteFocusedRow</strong> value to its <strong>Command</strong> property.</p>

<br/>


