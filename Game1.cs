#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace PacMan3D
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Box 
    {
        
        VertexPositionColor[] verts;
        List<VertexPositionColor[]> blockList;

        public List<VertexPositionColor[]> getBox(float x, float y, float z) 
        {
            blockList = new List<VertexPositionColor[]>();
            verts = new VertexPositionColor[3]
                    {
                        new VertexPositionColor(new Vector3(x, y + 1.0f, z), Color.Red),
                        new VertexPositionColor(new Vector3(x + 1.0f, y + 1.0f, z), Color.Blue),
                        new VertexPositionColor(new Vector3(x, y, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                        new VertexPositionColor(new Vector3(z, y, z), Color.Red),
                        new VertexPositionColor(new Vector3(x +1, y, z), Color.Blue),
                        new VertexPositionColor(new Vector3(x +1, y + 1.0f, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                        new VertexPositionColor(new Vector3(x , y + 1.0f, z +1), Color.Red),
                        new VertexPositionColor(new Vector3(x +1, y + 1.0f, z +1), Color.Blue),
                        new VertexPositionColor(new Vector3(x, 0.0f, z +1), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                        new VertexPositionColor(new Vector3(x, y, z +1), Color.Red),
                        new VertexPositionColor(new Vector3(x +1, y, z +1), Color.Blue),
                        new VertexPositionColor(new Vector3(x +1, y +1.0f, z +1), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                        new VertexPositionColor(new Vector3(x +1, y, z +1), Color.Red),
                        new VertexPositionColor(new Vector3(x +1, y + 1.0f, z +1), Color.Blue),
                        new VertexPositionColor(new Vector3(x +1, y, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                        new VertexPositionColor(new Vector3(x +1, y + 1.0f, z +1), Color.Red),
                        new VertexPositionColor(new Vector3(x +1, y + 1.0f, z), Color.Blue),
                        new VertexPositionColor(new Vector3(x +1, y, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3] 
                    {
                        new VertexPositionColor(new Vector3(x, y, z +1), Color.Red),
                        new VertexPositionColor(new Vector3(x, y + 1.0f, z +1), Color.Blue),
                        new VertexPositionColor(new Vector3(x, y, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                       new VertexPositionColor(new Vector3(x, y + 1.0f, z +1), Color.Red),
                       new VertexPositionColor(new Vector3(x, y + 1.0f, z), Color.Blue),
                       new VertexPositionColor(new Vector3(x, y, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                       new VertexPositionColor(new Vector3(x, y + 1.0f, z +1), Color.Red),
                       new VertexPositionColor(new Vector3(x +1, y + 1.0f, z +1), Color.Blue),
                       new VertexPositionColor(new Vector3(x +1, y + 1.0f, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                       new VertexPositionColor(new Vector3(x, y + 1.0f, z +1), Color.Red),
                       new VertexPositionColor(new Vector3(x, y + 1.0f, z), Color.Blue),
                       new VertexPositionColor(new Vector3(x +1, y + 1.0f, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                       new VertexPositionColor(new Vector3(x, y, z +1), Color.Red),
                       new VertexPositionColor(new Vector3(x +1, y, z +1), Color.Blue),
                       new VertexPositionColor(new Vector3(x +1, y, z), Color.Green),
                    };
            blockList.Add(verts);
            verts = new VertexPositionColor[3]
                    {
                       new VertexPositionColor(new Vector3(x, y, z +1), Color.Red),
                       new VertexPositionColor(new Vector3(x, y, z), Color.Blue),
                       new VertexPositionColor(new Vector3(x +1, y, z), Color.Green),
                    };
            blockList.Add(verts);
            return blockList;
        }
        
    };
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        

        List<VertexPositionColor[]> blockList;

        BasicEffect effect;
        VertexBuffer buffer;

        Vector3 position;
        float rotY;

        Box box;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            GraphicsDevice.RasterizerState = RasterizerState.CullNone;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            blockList = new List<VertexPositionColor[]>();
            List<VertexPositionColor[]> temp = new List<VertexPositionColor[]>();
            box = new Box();
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 13; i++)
                {

                    temp = box.getBox(i, j, 0);
                    foreach (VertexPositionColor[] block in temp) 
                    {
                        blockList.Add(block);
                    }
                }
            }
            

            effect = new BasicEffect(GraphicsDevice);

            buffer = new VertexBuffer(GraphicsDevice, VertexPositionColor.VertexDeclaration, 3, BufferUsage.WriteOnly);
            foreach (VertexPositionColor[] side in blockList) 
            {
                buffer.SetData(side);
            }


            position = new Vector3(0.0f, 0.0f, 2.0f);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            rotY += deltaTime * 0.2f;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            effect.Projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.PiOver4,
                GraphicsDevice.Viewport.AspectRatio, 0.001f, 1000.0f);
            effect.View = Matrix.CreateLookAt(new Vector3(0, 0, -10), Vector3.Forward, Vector3.Up);
            effect.World = Matrix.Identity * Matrix.CreateRotationZ(rotY) * Matrix.CreateTranslation(position) * Matrix.CreateRotationY(rotY) * Matrix.CreateRotationX(rotY);
            effect.VertexColorEnabled = true;

            foreach (EffectPass pass in effect.CurrentTechnique.Passes)
            {
                pass.Apply();

                foreach (VertexPositionColor[] side in blockList) 
                {
                    GraphicsDevice.DrawUserPrimitives<VertexPositionColor>(PrimitiveType.TriangleList, side, 0, 1);
                }
                
            }

            base.Draw(gameTime);
        }
    }
}
