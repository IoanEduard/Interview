namespace _LeetCode_Easy.Concrete.Struggle.MultidimensionalArrays
{
    public class FlippingAnImage
    {
         // Most likely I cheated because of the XOR operator 
        public int[][] FlipAndInvertImage(int[][] image)
        {

            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image.Length / 2; j++)
                {
                    var temp = image[i][j] ^ 1;
                    image[i][j] = image[i][image.Length - j - 1] ^ 1;
                    image[i][image.Length - j - 1] = temp;
                }
            }

            return image;
        }

    }
}