   M S B A M L   `   `   `  ���� K  GGetReport, Version=0.1.6705.18589, Culture=neutral, PublicKeyToken=null1clr-namespace:GetReport.ViewsGetReport.Views       GetReport.Views.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:GetReport.Views     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  	GetReport��$
��1024��$	��600�� � WindowState$ Normal=� � 	Resources    ReportListTemplateAOSR  LVStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   &	        &	      �� .R��� �� " ��.���  � ��
 ��İ���  � ��$ 5q���  � ��$ 5q� P�  �@��
IsSelected . . ���  � ��
 �������  � ��$ 1q���  � ��
 �   �	 J� InputBindings	 �� 

 �� Key$
 S�� �� 	Modifiers$
 Ctrlf� �� Command �� *	SaveCmd+��  �� Gesture$ Ctrl+Shift+S�� �� *	SaveAsCmd+�� $ Ctrl+O�� �� *	OpenCmd+�� $ Ctrl+N�� �� *NewCmd+�� $ Alt+F4�� �� *	ExitCmd+.��]� .+�+  %System.Windows.Controls.Ribbon.Ribbon  -     Name$ 	RibbonWin�����	#FFF1F1F1���	#FFC9C9C9$	��Top=� �� SelectedIndex$ 0��   HelpPaneContent 1  +System.Windows.Controls.Ribbon.RibbonButton  -   $��About��   SmallImageSource$ Images\info.png��   QuickAccessToolBar =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  .@�  -     Name$
 Save��$ Images\save.png��{��� *SaveSessionE+   ApplicationMenu :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  
���   �5  /System.Windows.Controls.Ribbon.RibbonMenuButton   KeyTip$ F��.@�>  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   $	��New�� m� InputGestureText$ Ctrl+N��{��� *NewSessionE+  -   $
��Open��$ Ctrl+O��{��� *OpenSessionE+  -   $
��Save��$ Ctrl+S��{��� *SaveSessionE+  $��Save As��$ Ctrl+Shift+S�� m� Command �� *	SaveAsCmd+{��� *SaveAsSessionE+4  .System.Windows.Controls.Ribbon.RibbonSeparator  m� $
��Exit��$ Alt+F4�� �� *	ExitCmd+.@�.  (System.Windows.Controls.Ribbon.RibbonTab  $
��Home��   KeyTip$ H��.@�0	  *System.Windows.Controls.Ribbon.RibbonGroup	  -    	 Name$ ClipboardGroup��$
��Home��.@�  -      KeyTip$ N��   Label$	 New��   LargeImageSource$ Images\document.png��{��� *NewSessionE+  -	   $ O��$
 Open��$ Images\folder.png��{��� *OpenSessionE+  -
   $ S��$
 Save��$ Images\save.png��{��� *SaveSessionE+	  -   $ Report��$��Report��.@�  -   $ A��$ 
Add report��$ Images\plus.png��{��� *AddReportToListE+  -   $ D��$ Delete selected��$ Images\delete.png��{��� *DeleteReportFromListE+3
  -System.Windows.Controls.Ribbon.RibbonCheckBox
  -    
 Name$ Expand1��$
��Lev1��
  -   $ Expand2��$
��Lev2��
  -   $ Expand3��$
��Lev3��  $ R��$ Copy to Right��$ Images\Right.png������ *!GetCreateNewReportInListCommand+  $ R��$ Copy to Right��$ Images\Left.png������ *!GetCreateNewReportInListCommand+	  -   $ Export��$��Publish��.@�  -   $ P��$ Publish��$ Images\word.png��  $ D��$ 	Delegates��$ Images\briefcase.png������ *ShowDelegateListDialogCmd+�� -    ��Name$ scvwr��.���� -    ��Name$ sessionReportList��$��Stretch=�$	��Top=�#��[ ���� .R��� $
��Left=�$	��Top=�  �� Orientation$  
Horizontal=����� .R�#   GetReport.Views.ReportOSRView  �� $��15��$��Bottom=�$��Bottom=�$��Bottom=�.@��� $��	StatusBar��