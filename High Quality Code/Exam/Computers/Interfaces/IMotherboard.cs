namespace ComputerParts
{
    public interface IMotherboard
    {
        /// <summary>
        /// Loading a single integer value from the memmory
        /// </summary>
        /// <returns>The Integer value to be loaded</returns>
        int LoadRamValue(); 

        /// <summary>
        /// Saving a single integer value in the memmory
        /// </summary>
        /// <param name="value">The integer value to be saved</param>
        void SaveRamValue(int value); 

        /// <summary>
        /// Draw given string on the console line.
        /// </summary>
        /// <param name="data">The given string</param>
        void DrawOnVideoCard(string data);
    }
}
