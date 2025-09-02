﻿using Microsoft.CodeAnalysis;
using RelationsNaN.Models;

namespace RelationsNaN.Data
{
    public class DbInitializer
    {
        protected RelationsNaNContext _context;

        public DbInitializer(RelationsNaNContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if (_context.Game.Count() == 0)
            {
                Game game1 = new Game()
                {
                    Name = "Dark Souls III",
                    ReleaseYear = 2016,
                    Image = "https://image.api.playstation.com/cdn/UP0700/CUSA03388_00/v8JlD8KcQUtTqaLBmpFnj1ESRR5zMkLk.png"
                };
                await _context.Game.AddAsync(game1);

                Game game2 = new Game()
                {
                    Name = "Super Smash Bros. Ultimate",
                    ReleaseYear = 2018,
                    Image = "https://assets.nintendo.com/image/upload/c_fill,w_1200/q_auto:best/f_auto/dpr_2.0/ncom/software/switch/70010000012332/ac4d1fc9824876ce756406f0525d50c57ded4b2a666f6dfe40a6ac5c3563fad9"
                };
                await _context.Game.AddAsync(game2);

                Game game3 = new Game()
                {
                    Name = "XCom 2",
                    ReleaseYear = 2016,
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/XCOM_2_cover_art.jpg/220px-XCOM_2_cover_art.jpg"
                };
                await _context.Game.AddAsync(game3);

                await _context.SaveChangesAsync();
            }

            if (_context.Plateforms.Count() == 0)
            {
                Plateform ps5 = new Plateform()
                {
                    Name = "PS4"
                };
                await _context.Plateforms.AddAsync(ps5);

                Plateform xbox360 = new Plateform()
                {
                    Name = "Xbox One"
                };
                await _context.Plateforms.AddAsync(xbox360);

                Plateform n64 = new Plateform()
                {
                    Name = "Switch"
                };
                await _context.Plateforms.AddAsync(n64);

                Plateform pc = new Plateform()
                {
                    Name = "PC"
                };
                await _context.Plateforms.AddAsync(pc);

                await _context.SaveChangesAsync();
            }
        }
    }
}
