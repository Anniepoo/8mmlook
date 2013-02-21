// ParallaxingBackground.cs
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class ShakyOverlay
    {

        // The image representing the parallaxing background
        Texture2D texture;


        // An array of positions of the parallaxing background
        Vector2[] positions;

        // The speed which the background is moving
        int speed;

        Random rand = new Random();

        public void Initialize(ContentManager content, String texturePath, int screenWidth, int speed)
        {
            // Load the background texture we will be using
            texture = content.Load<Texture2D>(texturePath);

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 pos = new Vector2(0, rand.Next(6)-6);
            spriteBatch.Draw(texture, pos, Color.White);
        }
    }
}
