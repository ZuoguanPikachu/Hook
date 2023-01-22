namespace Hook.Util
{
    internal class MouseMessage
    {
        /// <summary>
        /// The MOUSEMOVE message is posted to a window when the cursor moves. 
        /// </summary>
        public const int MOUSEMOVE = 0x200;

        /// <summary>
        /// The LBUTTONDOWN message is posted when the user presses the left mouse button 
        /// </summary>
        public const int LBUTTONDOWN = 0x201;

        /// <summary>
        /// The RBUTTONDOWN message is posted when the user presses the right mouse button
        /// </summary>
        public const int RBUTTONDOWN = 0x204;

        /// <summary>
        /// The MBUTTONDOWN message is posted when the user presses the middle mouse button 
        /// </summary>
        public const int MBUTTONDOWN = 0x207;

        /// <summary>
        /// The LBUTTONUP message is posted when the user releases the left mouse button 
        /// </summary>
        public const int LBUTTONUP = 0x202;

        /// <summary>
        /// The RBUTTONUP message is posted when the user releases the right mouse button 
        /// </summary>
        public const int RBUTTONUP = 0x205;

        /// <summary>
        /// The MBUTTONUP message is posted when the user releases the middle mouse button 
        /// </summary>
        public const int MBUTTONUP = 0x208;

        /// <summary>
        /// The LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button 
        /// </summary>
        public const int LBUTTONDBLCLK = 0x203;

        /// <summary>
        /// The RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button 
        /// </summary>
        public const int RBUTTONDBLCLK = 0x206;

        /// <summary>
        /// The RBUTTONDOWN message is posted when the user presses the right mouse button 
        /// </summary>
        public const int MBUTTONDBLCLK = 0x209;

        /// <summary>
        /// The MOUSEWHEEL message is posted when the user presses the mouse wheel. 
        /// </summary>
        public const int MOUSEWHEEL = 0x020A;
    }
}
