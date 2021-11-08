using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRating.API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeMovie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorsMovies",
                columns: table => new
                {
                    Actor_Id = table.Column<int>(type: "int", nullable: false),
                    Movie_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => new { x.Actor_Id, x.Movie_Id });
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_Actor_Id",
                        column: x => x.Actor_Id,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Movies_Movie_Id",
                        column: x => x.Movie_Id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Movie_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Movies_Movie_Id",
                        column: x => x.Movie_Id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Birthday", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meryl", "Female", "Streep" },
                    { 9, new DateTime(1950, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angelina", "Female", "Jolie" },
                    { 8, new DateTime(1971, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denzel", "Male", "Washington" },
                    { 7, new DateTime(1986, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", "Male", "Spacey" },
                    { 6, new DateTime(1978, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al", "Male", "Pacino" },
                    { 10, new DateTime(1979, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", "Male", "Cruise" },
                    { 4, new DateTime(1995, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnny", "Male", "Depp" },
                    { 3, new DateTime(1983, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lupita", "Female", "Nyong'o" },
                    { 2, new DateTime(1980, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margot", "Female", "Robbie" },
                    { 5, new DateTime(2008, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "Male", "De Niro" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "Description", "RelaseDate", "Title", "TypeMovie" },
                values: new object[,]
                {
                    { 32, "http://image.tmdb.org/t/p/w185/y95lQLnuNKdPAzw9F9Ab8kJ80c3.jpg", "The Bad Boys Mike Lowrey and Marcus Burnett are back together for one last ride in the highly anticipated Bad Boys for Life.", new DateTime(2000, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bad Boys for Life (2020)", "Movies" },
                    { 25, "http://image.tmdb.org/t/p/w185/2433Vt8xuDnAIDAJTNx6DEtf9Qb.jpg", "As his wedding day approaches, Ben heads to Miami with his soon-to-be brother-in-law James to bring down a drug dealer who's supplying the dealers of Atlanta with product.", new DateTime(2014, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ride Along 2", "TV Shows" },
                    { 26, "http://image.tmdb.org/t/p/w185/vOl6shtL0wknjaIs6JdKCpcHvg8.jpg", "A bride's wedding night takes a sinister turn when her eccentric new in-laws force her to take part in a terrifying game.", new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ready or Not (2019)", "Movies" },
                    { 27, "http://image.tmdb.org/t/p/w185/jJ8TnHvWHaVadW5JJjGYsM07j9i.jpg", "Lightning McQueen sets out to prove to a new generation of racers that he's still the best race car in the world.", new DateTime(2011, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cars 3", "Movies" },
                    { 28, "http://image.tmdb.org/t/p/w185/xLPffWMhMj1l50ND3KchMjYoKmE.jpg", "Arthur Curry learns that he is the heir to the underwater kingdom of Atlantis, and must step forward to lead his people and to be a hero to the world.", new DateTime(2012, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aquaman", "Movies" },
                    { 29, "http://image.tmdb.org/t/p/w185/r7vmZjiyZw9rpJMQJdXpjgiCOk9.jpg", "A group of space criminals must work together to stop the fanatical villain Ronan the Accuser from destroying the galaxy.", new DateTime(2011, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy", "TV Shows" },
                    { 30, "http://image.tmdb.org/t/p/w185/aKx1ARwG55zZ0GpRvU2WrGrCG9o.jpg", "A young Chinese maiden disguises herself as a male warrior in order to save her father.", new DateTime(2000, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mulan (2020)", "TV Shows" },
                    { 31, "http://image.tmdb.org/t/p/w185/lcyKve7nXRFgRyms9M1bndNkKOx.jpg", "A criminal mastermind unleashes a twisted form of justice in Spiral, the terrifying new chapter from the book of Saw.", new DateTime(2003, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spiral", "Movies" },
                    { 33, "http://image.tmdb.org/t/p/w185/4JeejGugONWpJkbnvL12hVoYEDa.jpg", "In Ancient Polynesia, when a terrible curse incurred by Maui reaches an impetuous Chieftain's daughter's island, she answers the Ocean's call to seek out the demigod to set things right.", new DateTime(2006, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moana", "TV Shows" },
                    { 38, "http://image.tmdb.org/t/p/w185/kwh9dYvZLn7yJ9nfU5sPj2h9O7l.jpg", "Follow-up film to the 2006 comedy centering on the real-life adventures of a fictional Kazakh television journalist named Borat.", new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borat Subsequent Moviefilm (2020)", "Movies" },
                    { 35, "http://image.tmdb.org/t/p/w185/if4hw3Ou5Sav9Em7WWHj66mnywp.jpg", "A fantasy re-telling of the medieval story of Sir Gawain and the Green Knight.", new DateTime(2001, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Green Knight (2021)", "Movies" },
                    { 36, "http://image.tmdb.org/t/p/w185/rzRwTcFvttcN1ZpX2xv4j3tSdJu.jpg", "Imprisoned, the mighty Thor finds himself in a lethal gladiatorial contest against the Hulk, his former ally. Thor must fight for survival and race against time to prevent the all-powerful Hela from destroying his home and the Asgardian civilization.", new DateTime(2005, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor: Ragnarok", "Movies" },
                    { 37, "http://image.tmdb.org/t/p/w185/wp6OxE4poJ4G7c0U2ZIXasTSMR7.jpg", "When Jane Foster is possessed by a great power, Thor must protect her from a new threat of old times: the Dark Elves.", new DateTime(2010, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor: The Dark World", "Movies" },
                    { 24, "http://image.tmdb.org/t/p/w185/tBUYDwiJVDcnjPneOitVetJk2Rt.jpg", "Mankind's earliest settlers on the Martian frontier do what they must to survive the cosmic elements and each other.", new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Settlers (2021)", "Movies" },
                    { 39, "http://image.tmdb.org/t/p/w185/mPrDJ7puYzPLG5kPM96iNszF2sM.jpg", "On Anna's birthday, Elsa and Kristoff are determined to give her the best celebration ever, but Elsa's icy powers may put more than just the party at risk.", new DateTime(2015, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frozen Fever", "Movies" },
                    { 40, "http://image.tmdb.org/t/p/w185/xf8PbyQcR5ucXErmZNzdKR0s8ya.jpg", "A former neurosurgeon embarks on a journey of healing only to be drawn into the world of the mystic arts.", new DateTime(2016, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Strange", "TV Shows" },
                    { 41, "http://image.tmdb.org/t/p/w185/uxzzxijgPIY7slzFvMotPv8wjKA.jpg", "T'Challa, after the death of his father, the King of Wakanda, returns home to the isolated, technologically advanced African nation to succeed to the throne and take his rightful place as king.", new DateTime(2015, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Panther", "Movies" },
                    { 42, "http://image.tmdb.org/t/p/w185/cycDz68DtTjJrDJ1fV8EBq2Xdpb.jpg", "Thomas and Bea are now married and living with Peter and his rabbit family. Bored of life in the garden, Peter goes to the big city, where he meets shady characters and ends up creating chaos for the whole family.", new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Rabbit 2: The Runaway (2021)", "Movies" },
                    { 43, "http://image.tmdb.org/t/p/w185/6GCOpT8QcNzup09TAMmvvk22LTR.jpg", "John Clark, a Navy SEAL, goes on a path to avenge his wife's murder only to find himself inside of a larger conspiracy.", new DateTime(2010, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Clancy's Without Remorse (2021)", "TV Shows" },
                    { 34, "http://image.tmdb.org/t/p/w185/qwoGfcg6YUS55nUweKGujHE54Wy.jpg", "Captain Jack Sparrow searches for the trident of Poseidon.", new DateTime(2012, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: Dead Men Tell No Tales", "Movies" },
                    { 23, "http://image.tmdb.org/t/p/w185/BzVjmm8l23rPsijLiNLUzuQtyd.jpg", "As a CODA (Child of Deaf Adults) Ruby is the only hearing person in her deaf family. When the family's fishing business is threatened, Ruby finds herself torn between pursuing her love of music and her fear of abandoning her parents.", new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CODA (2021)", "Movies" },
                    { 18, "http://image.tmdb.org/t/p/w185/uIXF0sQGXOxQhbaEaKOi2VYlIL0.jpg", "A G.I. Joe spin-off centered around the character of Snake Eyes.", new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snake Eyes", "TV Shows" },
                    { 21, "http://image.tmdb.org/t/p/w185/faJK0dP3S92kQoKtO4LZMjy41kf.jpg", "In a twisted social experiment, 80 Americans are locked in their high-rise corporate office in Bogot�, Colombia and ordered by an unknown voice coming from the company's intercom system to participate in a deadly game of kill or be killed.", new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Belko Experiment", "Movies" },
                    { 1, "http://image.tmdb.org/t/p/w185/xmbU4JTUm8rsdtn7Y3Fcm30GpeT.jpg", "A bank teller discovers that he's actually an NPC inside a brutal, open world video game.", new DateTime(2013, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Guy (2021)", "Movies" },
                    { 2, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/dqoshZPLNsXlC1qtz5n34raUyrE.jpg", "A sequel to the horror film Candyman (1992) that returns to the now-gentrified Chicago neighborhood where the legend began.", new DateTime(2013, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Candyman", "TV Shows" },
                    { 3, "http://image.tmdb.org/t/p/w185/cGLL4SY6jFjjUZkz2eFxgtCtGgK.jpg", "A vacationing family discovers that the secluded beach where they're relaxing for a few hours is somehow causing them to age rapidly, reducing their entire lives into a single day.", new DateTime(2005, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Old", "Movies" },
                    { 4, "http://image.tmdb.org/t/p/w185/1N5e56325vwih8IeJ29k9FZf8p8.jpg", "Madison is paralyzed by shocking visions of grisly murders, and her torment worsens as she discovers that these waking dreams are in fact terrifying realities.", new DateTime(2012, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malignant (2021)", "Movies" },
                    { 5, "http://image.tmdb.org/t/p/w185/kb4s0ML0iVZlG6wAKbbs9NAm6X.jpg", "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", new DateTime(2009, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad (2021)", "TV Shows" },
                    { 6, "http://image.tmdb.org/t/p/w185/9424zyRdWp3Ze5XHsXZd64FeFGY.jpg", "A notorious criminal must break an evil curse in order to rescue an abducted girl who has mysteriously disappeared.", new DateTime(2012, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prisoners of the Ghostland (2021)", "Movies" },
                    { 7, "http://image.tmdb.org/t/p/w185/ysJte1iqN8pFQ470tumnViB1wHP.jpg", "Follows Alex, a boy obsessed with scary stories who is imprisoned by an evil young witch in her contemporary New York City apartment.", new DateTime(2002, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nightbooks", "Movies" },
                    { 8, "http://image.tmdb.org/t/p/w185/jGYJyPzVgrVV2bgClI9uvEZgVLE.jpg", "Six people unwittingly find themselves locked in another series of escape rooms, slowly uncovering what they have in common to survive. Joining forces with two of the original survivors, they soon discover they've all played the game before.", new DateTime(2009, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escape Room: Tournament of Champions (2021)", "Movies" },
                    { 9, "http://image.tmdb.org/t/p/w185/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg", "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.", new DateTime(2010, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow (2021)", "TV Shows" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "Description", "RelaseDate", "Title", "TypeMovie" },
                values: new object[,]
                {
                    { 22, "http://image.tmdb.org/t/p/w185/p70dq1YxabemdZDm5K6Q8G10wSn.jpg", "A mystery centered around the construction of the Great Wall of China.", new DateTime(2006, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Wall", "TV Shows" },
                    { 10, "http://image.tmdb.org/t/p/w185/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg", "Dom and the crew must take on an international terrorist who turns out to be Dom and Mia's estranged brother.", new DateTime(2000, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9: The Fast Saga", "Movies" },
                    { 12, "http://image.tmdb.org/t/p/w185/cPdmPwcIcmu0ugfKcdFtI3vmOJq.jpg", "A father travels from Oklahoma to France to help his estranged daughter, who is in prison for a murder she claims she didn't commit.", new DateTime(2008, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stillwater (2021)", "TV Shows" },
                    { 13, "http://image.tmdb.org/t/p/w185/lB068qa6bQ0QKYKyC2xnYGvYjl7.jpg", "All the rules are broken as a sect of lawless marauders decides that the annual Purge does not stop at daybreak and instead should never end.", new DateTime(2010, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Forever Purge (2021)", "Movies" },
                    { 14, "http://image.tmdb.org/t/p/w185/34BmdJkdvRweC3xJJFlOFQ2IbYc.jpg", "A group of criminals are brought together under mysterious circumstances and have to work together to uncover what's really going on when their simple job goes completely sideways.", new DateTime(2017, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Sudden Move (2021)", "TV Shows" },
                    { 15, "http://image.tmdb.org/t/p/w185/oBgWY00bEFeZ9N25wWVyuQddbAo.jpg", "A bystander who intervenes to help a woman being harassed by a group of men becomes the target of a vengeful drug lord.", new DateTime(2012, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody", "TV Shows" },
                    { 16, "http://image.tmdb.org/t/p/w185/tbTiSr0v9g8Q34MIeIcT0o2vGus.jpg", "A mind-bending love story following Greg who, after recently being divorced and then fired, meets the mysterious Isabel, a woman living on the streets and convinced that the polluted, broken world around them is a computer simulation.", new DateTime(2013, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bliss (2021)", "TV Shows" },
                    { 17, "http://image.tmdb.org/t/p/w185/dPOyYnCkRbWAEem85N3VFpQODf5.jpg", "After being recruited by a group of unconventional thieves, renowned criminal Richard Pace finds himself caught up in an elaborate gold heist that promises to have far-reaching implications on his life and the lives of countless others.", new DateTime(2001, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Misfits", "TV Shows" },
                    { 44, "http://image.tmdb.org/t/p/w185/z8onk7LV9Mmw6zKz4hT6pzzvmvl.jpg", "Blacksmith Will Turner teams up with eccentric pirate \"Captain\" Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: The Curse of the Black Pearl", "TV Shows" },
                    { 19, "http://image.tmdb.org/t/p/w185/wxLUQ1pIms3HAlVGYvEG9zg2kDs.jpg", "Jack Reacher must uncover the truth behind a major government conspiracy in order to clear his name. On the run as a fugitive from the law, Reacher uncovers a potential secret from his past that could change his life forever.", new DateTime(2008, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Reacher: Never Go Back", "Movies" },
                    { 20, "http://image.tmdb.org/t/p/w185/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg", "Based on Disneyland's theme park ride where a small riverboat takes a group of travelers through a jungle filled with dangerous animals and reptiles but with a supernatural element.", new DateTime(2011, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise", "Movies" },
                    { 11, "http://image.tmdb.org/t/p/w185/hRMfgGFRAZIlvwVWy8DYJdLTpvN.jpg", "The sequel is set in the years following the initial deadly home invasion, where Norman Nordstrom (Stephen Lang) lives in quiet solace until his past sins catch up to him.", new DateTime(2008, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't Breathe 2 (2021)", "TV Shows" },
                    { 45, "http://image.tmdb.org/t/p/w185/nztAld019tFjllW7VCJvPFiFkt8.jpg", "As a math savant uncooks the books for a new client, the Treasury Department closes in on his activities and the body count starts to rise.", new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Accountant", "Movies" }
                });

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 1, 33 },
                    { 8, 32 },
                    { 6, 32 },
                    { 6, 31 },
                    { 5, 31 },
                    { 6, 30 },
                    { 3, 30 },
                    { 1, 29 },
                    { 5, 33 },
                    { 5, 29 },
                    { 3, 28 },
                    { 5, 27 },
                    { 9, 27 },
                    { 7, 26 },
                    { 5, 26 },
                    { 1, 25 },
                    { 9, 25 },
                    { 8, 24 },
                    { 7, 28 },
                    { 6, 34 },
                    { 5, 34 },
                    { 9, 35 },
                    { 2, 44 },
                    { 8, 44 },
                    { 7, 43 },
                    { 1, 43 },
                    { 5, 42 },
                    { 1, 42 },
                    { 2, 41 },
                    { 6, 41 },
                    { 2, 40 },
                    { 6, 40 },
                    { 6, 39 },
                    { 1, 39 },
                    { 3, 38 },
                    { 6, 38 },
                    { 1, 37 },
                    { 4, 37 },
                    { 2, 36 },
                    { 7, 36 },
                    { 2, 35 }
                });

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 9, 24 },
                    { 7, 23 },
                    { 4, 23 },
                    { 2, 22 },
                    { 4, 10 },
                    { 2, 10 },
                    { 7, 9 },
                    { 2, 9 },
                    { 3, 8 },
                    { 9, 8 },
                    { 8, 7 },
                    { 9, 7 },
                    { 7, 6 },
                    { 1, 6 },
                    { 9, 5 },
                    { 7, 5 },
                    { 2, 4 },
                    { 9, 4 },
                    { 7, 3 },
                    { 6, 3 },
                    { 8, 2 },
                    { 7, 2 },
                    { 7, 1 },
                    { 7, 11 },
                    { 5, 45 },
                    { 1, 11 },
                    { 1, 12 },
                    { 4, 22 },
                    { 6, 21 },
                    { 8, 21 },
                    { 9, 20 },
                    { 5, 20 },
                    { 3, 19 },
                    { 2, 19 },
                    { 8, 18 },
                    { 6, 18 },
                    { 1, 17 },
                    { 9, 17 },
                    { 7, 16 },
                    { 8, 16 },
                    { 8, 15 },
                    { 3, 15 }
                });

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 3, 14 },
                    { 8, 14 },
                    { 1, 13 },
                    { 3, 13 },
                    { 8, 12 },
                    { 6, 45 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_Movie_Id",
                table: "ActorsMovies",
                column: "Movie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_Movie_Id",
                table: "Rating",
                column: "Movie_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
