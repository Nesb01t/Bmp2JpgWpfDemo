   M S B A M L   `   `   `  ����I  EBmp2JpgWpfDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Bmp2JpgWpfDemoBmp2JpgWpfDemo  5   	       Bmp2JpgWpfDemo.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Bmp2JpgWpfDemo     5   	     � Title$  Bmp2Jpg Converter��5   	   $	��450��6#   $	��800��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��10q�6!   $��Source Image Path:��6-   �� 5   
   -   5         ��Name$ txtSourcePath��5   +   $��1��6   $��10q�6   6+   �� 5   
   -   5        $��2��5      $��10q�6   $��
Open Image��6*   6?   �� 5   
   $��3��6   $��10q�6!   $"��Compression Quality (1-100):��6-   �� 5   
   -   5         ��Name$ sliderQuality��5   *   $��4��6   $��10q�6    � Minimum$ 1Q�6A    � Maximum$	 100Q�6M    � Value$ 80Q�6[   �� 5   
   -   5        $��5��5      $��10q�6   $��Convert��6*   6<   �� 5   
   -   5         ��Name$ 
imgPreview��5   )   $��6��6   $��10q�6   6)   5      5       