   M S B A M L   `   `   `  ����K  GMidterm_Airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Midterm_AirlinesMidterm_Airlines  5   	   !    Midterm_Airlines.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Midterm_Airlines     5   	   -   5          � Title$  
MainWindow��5   	   $	��433��6   $	��620��6)   ���#C5C4C2 � ContextMenu 5	      �� 5
   
   .@�5      m� -   5         m�Name$ 	File_Menu��5      $
��File��6*   .@�5      m� -   5        $ New_Home��5      $	��New��6-   $��12(�6:   m� 5      -   5        $ 	Save_Home��5      $
��Save��6.   m� 5      -   5        $ 	Quit_Home��5      $
��Quit��6.   $��12(�6O   5      m� 5      -   5        $ 	Edit_Menu��5      $
��Edit��6*   .@�5      m� $��Insert��6   m� 5      $��Update��6   m� 5      $��Delete��6   5      m� 5      -   5        $ 	View_Menu��5      $
��View��6*   .@�5      m� -   5        $ Customers_view��5      $��	Customers��63   $��12(�6^   m� 5      -	   5        $ Airlines_view��5      $��Airlines��62   $��12(�6[   m� 5      -
   5        $ Flights_view��5      $��Flights��61   $��12(�6X   m� 5      -   5        $ Passengers_view��5      $��
Passengers��64   $��12(�6a   5      5      .��5      � 
����ح�.+�5   
   ]� $��False��6   $��	0,0,0,359q�6*   o� 5   
   -   5         o�Name$ HMenu��5      $��25��6   $��	0,0,0,373q�6*   ���	#FF4388C0.@�5       m� -   5        $
 File��5       $
��File��6%   $��Arial)�63   $��24��6F   .@�5!      m� -   5        $	 New��5!      $	��New��6(   $��Arial)�65   m� 5"      -   5        $
 Save��5"      $
��Save��6)   $��Arial)�67   m� 5#      -   5        $
 Quit��5#      $
��Quit��6)   $��Arial)�67   6J   5$      m� 5%      -   5        $
 Edit��5%      $
��Edit��6%   $��Arial)�63   $��24��6F   .@�5&      m� $��Insert��6   $��Arial)�6+   m� 5'      $��Update��6   $��Arial)�6+   m� 5(      $��Delete��6   $��Arial)�6+   5)      m� 5*      -   5        $
 View��5*      $
��View��6%   $��Arial)�63   $��24��6F   .@�5+      m� -   5        $ 	Customers��5+      $��	Customers��6.   $��Arial)�6Y   m� 5,      -   5        $ Airlines��5,      $��Airlines��6-   $��Arial)�6V   m� 5-      -   5        $ Flights��5-      $��Flights��6,   $��Arial)�6S   m� 5.      -   5        $ 
Passengers��5.      $��
Passengers��6/   $��Arial)�6\   5/      m� 50      -   5        $
 Help��50      $
��Help��6%   $��Arial)�63   $��24��6F   6R   51      �� 52   
   $,��&Welcome To Airlines Reservation System��6   $
��Left=�6A   $��
20,199,0,0q�6\   $	��Top=�6p   $	��593��6�   $��38��6�   $��Center=�6�   $
��Bold"�6�   $��16(�6�   �� 53   
   $
��Left=�6   $��
59,242,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��55��6o   $	��521��6{   $��Arial)�6�   �� 6�   $���Welcome to our airline service and reservation system. We are here to provide you one of the quick and best airline services to all the customers. Customers can explore our services by clicking on the below given ��6�   �� 6~   � Language$ en-ca�6�  $�pages.��6�  6�  �� 54   
   $��	0,300,0,0q�6    �� Orientation$ 
Horizontal=�6(   ���	#FF4388C0.+�55      �� -   5         ��Name$ Custbtn��55      $��	Customers��6&   $��32��6:   $��31,000q�6F   $��81��6V   $
��Bold"�6a   $��14(�6s   ���	#FFF76439���	#FF13100F
�������$��Arial)�6�   �� 56      -   5        $ Airbtn��56      $��Airlines��6%   $��32��68   $��31,000q�6D   $��81��6T   $
��Bold"�6_   $��14(�6q   ���	#FFF76439���	#FF13100F
�������$��Arial)�6�   �� 57      -   5        $ 	Flightbtn��57      $��Flights��6(   $��32��6:   $��31,000q�6F   $��81��6V   $
��Bold"�6a   $��14(�6s   ���	#FFF76439���	#FF13100F
�������$��Arial)�6�   �� 58      -   5        $ Passengerbtn��58      $��
Passengers��6+   $��32��6@   $��31,000q�6L   $��81��6\   $
��Bold"�6g   $��14(�6y   ���	#FFF76439���	#FF13100F
�������$��Arial)�6�   59      �� 5:   
   $��/airline2.jpg��6   $
��Left=�6'   $	��122��6B   $��
325,58,0,0q�6O   $	��Top=�6c   $	��219��6{   �� 5;   
   $��/airline.jpg��6   $
��Left=�6&   $	��120��6A   $��	42,59,0,0q�6N   $	��Top=�6a   $	��214��6y   5<      5=      