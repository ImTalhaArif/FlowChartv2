   M S B A M L   `   `   `  ����  ZoomExample    ZoomExample.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   b ^SharpVectors.Converters.Wpf, Version=1.7.6.0, Culture=neutral, PublicKeyToken=b532964b8548be770SVG&http://sharpvectors.codeplex.com/svgc/  5   	     � Title$  
MainWindow��5   @   $	��800��6S   $
��1500��6`   ���	#FFCB7373 � WindowStyle$ ThreeDBorderWindow=�6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $ Resources.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ slider��5   _   $��0��6    �� Orientation$ Vertical=�6!   $
��Left=�68    � Minimum$ 1Q�6S   6_   �� 5   
   -   5        $��scrollViewer��5      $��1��6+   $��Visible=�6;   $��Visible=�6a   .��5      � -   5        $
��grid��5      $
��1300��6   $	��800��6,   	 J� RenderTransformOrigin$	 0.5,0.5&�69   
 � LayoutTransform
 5      V� 5      .~�5      �� -   5        scaleTransform��5   )   5      .+�5      (� $��0��6   $��0��6*   .��5      �� -   5         ��Name$ canvasss��5      
������ $	��303��6H   $	��583��6U    J� 	AllowDrop . $	 	0.53,0.53&�6�   .+�5      � -   5        $��popup1��5        � VerticalOffset$ 20��6/    � PlacementRectangle$ 300,140,100,150�6D   $
��Fade=�6i   $��300,100,100,10q�6�   $��Mouse=�6�   ��.  .��5!      �� $	��100��6&   $��10��62   $��7(�6>   5%      � 5&      -   5        $��popup2��5&       $ 20��6/   $ 200,80,90,130�6D   $
��Fade=�6g   $��200,100,100,10q�6~   $��Mouse=�6�   ��.  .��5*      �� $	��100��6&   $��10��62   $��7(�6>   
���   �6K   5.      (  "SharpVectors.Converters.SvgViewbox  51      $	 1.213,0.614&�6)    �� Left$	 223��6M   
 �� Top$	 134��6_   $��60��6p   $��92��6|   z�52      V� 53   "   .~�54   &   �� �� 55   &   �� 56   &    �� Angle$ 0.594Q�66   T� 57   &   58   #   5:      5@      5B      5C      5E      � 5F   
   $��2��6   $
��Left=�6#   
���   �$	��759��6Q   $��8,0,0,0q�6^   $	��Top=�6o   $	��153��6�   �� 5G   
   -   5        $��	flowchart��5G   &   $��FlowChartUI��6   
�������$��1��6J   $
��Left=�6Z   $��42��6u   $��5,10,0,0q�6�   $	��Top=�6�   $	��160��6�   $
��Bold"�6�   $��20(�6�   $��Trebuchet MS)�6�   �� 5I   
    �� Orientation$ Vertical=�6   .+�5K      �� -	   5         ��Name$
 OPEN��5L      $��60��5M      $��22                 ��5N      $��5,10,0,0q�5O      $
��Left=�5P      $	��Top=�5Q      $
��OPEN��5S       � Cursor$
 Hand��5T      $��13(�5U      $
��Bold"�5V      $	 0.137,0.114&�5W      �� 5\      -
   5        $
 SAVE��5]      $��60��5^      $��22                 ��5_      $��5,6,0,0q�5`      $
��Left=�5a      $	��Top=�5b      $
��SAVE��5d      $
 Hand��5e      $��13(�5f      $
��Bold"�5g      $	 0.137,0.114&�5h      �� 5i      -   5        $ EXPORT��5j      $��60��5k      $��22                 ��5l      $��5,6,0,0q�5m      $
��Left=�5n      $	��Top=�5o      $
��SAVE��5q      $
 Hand��5r      $��13(�5s      $
��Bold"�5t      $	 0.137,0.114&�5u      �� 5w      -   5        $	��135��5x      $��40��5y      $��5,40,0,0q�5z      $
��Left=�5{      $	��Top=�5|      
�������
���   �$��2q�5      $��Magnet��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $
��Flag��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��Treasure��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��Speaker��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��	BackTrack��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��OUTPUT��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��	HOMOPHONE��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��BUCKET��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $	��135��5�      $��40��5�      $��5,6,0,0q�5�      $
��Left=�5�      $	��Top=�5�      
�������
���   �$��2q�5�      $��SCALE��5�      $
 Hand��5�      $��16(�5�      �� 5�      -   5        $��60��5�      $��20��5�      $
��left=�5�      $	��top=�5�      $��80,5,0,0q�5�      
�������
���   �$��1q�5�      $	��AND��5�      
�������$��16(�5�      $
 Hand��5�      $
��Bold"�5�   (   $��Expanded&�6:   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6Q      TextHintingMode$ Animated=�6z   5     �� 5     -   5        $��60��5     $��20��5     $
��left=�5     $	��top=�5	     $��80,5,0,0q�5
     
�������
���   �$��1q�5     $	��val��5     
�������$��16(�5     $
 Hand��5     $
��Bold"�5  (   $��Expanded&�6:   $ Display=�6Q   $ Animated=�6z   5     �� 5     -   5        $��60��5     $��20��5     $
��left=�5     $	��top=�5     $��	0,-20,0,0q�5      
�������
���   �$��1q�5#     $��OR��5$     
�������$��16(�5'     $
 Hand��5(     $
��Bold"�5)  (   $��Expanded&�6:   $ Display=�6Q   $ Animated=�6z   5/     �� 50     $��60��51     $��20��52     $
��left=�53     $	��top=�54     $��0,30,0,0q�55     
�������
�������$��2q�58     $��\��59     
���   �5:  *   �� 5;     $��60��5<     $��20��5=     $
��left=�5>     $	��top=�5?     $��
80,-20,0,0q�5@     
�������
�������$��2q�5C     $��X��5D     
���   �5E  *   5F     5H     5J     