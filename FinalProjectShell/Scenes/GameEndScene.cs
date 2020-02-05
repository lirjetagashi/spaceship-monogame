﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FinalProjectShell
{
    class GameEndScene : GameScene
    {
        public GameEndScene(Game game) : base(game)
        {
        }
        
        public override void Initialize()
        {
            AddComponent(new GameEndTextComponent(Game));
            this.Hide();
            base.Initialize();
        }

        /// <summary>
        /// This will be called when the game updates itself
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values</param>
        public override void Update(GameTime gameTime)
        {
            if (Enabled)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                {
                    ((Game1)Game).HideAllScenes();
                    Game.Services.GetService<StartScene>().Show();
                }
            }

            base.Update(gameTime);
        }
        
    }
}