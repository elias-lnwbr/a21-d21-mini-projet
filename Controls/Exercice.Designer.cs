﻿namespace TorreDeBabel {
abstract partial class Exercice {
private System.ComponentModel.IContainer components = null;

protected override void
Dispose(bool disposing)
{
	if (disposing && (components != null)) {
		components.Dispose();
	}
	base.Dispose(disposing);
}

private void
InitializeComponent()
{
	this.SuspendLayout();
	this.ResumeLayout(false);
}
}
}
