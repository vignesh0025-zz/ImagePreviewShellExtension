using SharpShell.Attributes;
using System;
using System.Runtime.InteropServices;
using SharpShell.SharpPreviewHandler;
using System.Drawing;

[ComVisible(true)]
[COMServerAssociation(AssociationType.ClassOfExtension, ".tga")]
[DisplayName("TGA Preview Handler")]
[Guid("23592D34-78BA-4F43-AA6A-19716561C36C")]
[PreviewHandler(DisableLowILProcessIsolation = false)]
public class PreviewHandler : SharpPreviewHandler
{
        
        protected override PreviewHandlerControl DoPreview()
        {
            var ctrl = new PreviewControl();
            ctrl.DoPreview(SelectedFilePath);
            ctrl.BackColor = Color.Green;
            return ctrl;
        }
}




