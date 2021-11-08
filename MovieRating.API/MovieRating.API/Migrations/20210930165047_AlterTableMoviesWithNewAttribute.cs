using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRating.API.Migrations
{
    public partial class AlterTableMoviesWithNewAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 43 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 37 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 33 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 45 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 21 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 30 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 31 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 32 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 39 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 40 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 41 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 26 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 28 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 43 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 21 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 44 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 25 });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(1987, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1982, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1999, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1994, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthday",
                value: new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthday",
                value: new DateTime(1980, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Birthday",
                value: new DateTime(1964, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Birthday",
                value: new DateTime(2009, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Birthday",
                value: new DateTime(1961, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 9, 1 },
                    { 8, 34 },
                    { 1, 34 },
                    { 9, 33 },
                    { 8, 33 },
                    { 1, 32 },
                    { 6, 28 },
                    { 9, 30 },
                    { 7, 30 },
                    { 7, 29 },
                    { 9, 29 },
                    { 5, 35 },
                    { 4, 31 },
                    { 3, 37 },
                    { 7, 40 },
                    { 9, 38 },
                    { 3, 39 },
                    { 7, 39 },
                    { 4, 40 },
                    { 1, 28 },
                    { 1, 41 },
                    { 4, 42 },
                    { 7, 42 },
                    { 2, 43 },
                    { 5, 43 },
                    { 4, 44 },
                    { 9, 44 },
                    { 2, 45 },
                    { 2, 37 },
                    { 1, 27 },
                    { 8, 41 },
                    { 4, 26 }
                });

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 9, 11 },
                    { 6, 10 },
                    { 6, 9 },
                    { 7, 8 },
                    { 4, 8 },
                    { 8, 6 },
                    { 6, 6 },
                    { 4, 12 },
                    { 2, 5 },
                    { 1, 4 },
                    { 4, 4 },
                    { 3, 3 },
                    { 1, 3 },
                    { 1, 2 },
                    { 3, 2 },
                    { 3, 1 },
                    { 1, 5 },
                    { 3, 26 },
                    { 2, 14 },
                    { 3, 21 },
                    { 3, 24 },
                    { 6, 23 },
                    { 1, 23 },
                    { 3, 22 },
                    { 1, 22 },
                    { 1, 21 },
                    { 5, 15 },
                    { 4, 25 },
                    { 7, 20 },
                    { 4, 19 },
                    { 5, 18 },
                    { 3, 18 },
                    { 6, 17 },
                    { 7, 17 },
                    { 4, 16 },
                    { 1, 15 },
                    { 1, 20 },
                    { 5, 25 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "RelaseDate",
                value: new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "RelaseDate",
                value: new DateTime(2004, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "RelaseDate",
                value: new DateTime(2006, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "RelaseDate",
                value: new DateTime(2012, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "RelaseDate",
                value: new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "RelaseDate",
                value: new DateTime(2006, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "RelaseDate",
                value: new DateTime(2002, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "RelaseDate",
                value: new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "RelaseDate",
                value: new DateTime(2004, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "RelaseDate",
                value: new DateTime(2009, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "RelaseDate",
                value: new DateTime(2010, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "RelaseDate",
                value: new DateTime(2011, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "RelaseDate",
                value: new DateTime(2004, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "RelaseDate",
                value: new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "RelaseDate",
                value: new DateTime(2002, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "RelaseDate",
                value: new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "RelaseDate",
                value: new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "RelaseDate",
                value: new DateTime(2009, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "RelaseDate",
                value: new DateTime(2017, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "RelaseDate",
                value: new DateTime(2009, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "RelaseDate",
                value: new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "RelaseDate",
                value: new DateTime(2002, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "RelaseDate",
                value: new DateTime(2001, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "RelaseDate",
                value: new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "RelaseDate",
                value: new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "RelaseDate",
                value: new DateTime(2000, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "RelaseDate",
                value: new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "RelaseDate",
                value: new DateTime(2012, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "RelaseDate",
                value: new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "RelaseDate",
                value: new DateTime(2009, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "RelaseDate",
                value: new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "RelaseDate",
                value: new DateTime(2015, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "RelaseDate",
                value: new DateTime(2002, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "RelaseDate",
                value: new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "RelaseDate",
                value: new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "RelaseDate",
                value: new DateTime(2003, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "RelaseDate",
                value: new DateTime(2000, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "RelaseDate",
                value: new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "RelaseDate",
                value: new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "RelaseDate",
                value: new DateTime(2017, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "RelaseDate",
                value: new DateTime(2015, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "RelaseDate",
                value: new DateTime(2018, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "RelaseDate",
                value: new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "RelaseDate",
                value: new DateTime(2011, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "RelaseDate",
                value: new DateTime(2015, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 2, 45 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 37 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 26 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 40 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 42 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 4, 44 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 6, 28 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 29 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 39 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 40 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 7, 42 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 33 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 34 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 8, 41 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 29 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 30 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 33 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 38 });

            migrationBuilder.DeleteData(
                table: "ActorsMovies",
                keyColumns: new[] { "Actor_Id", "Movie_Id" },
                keyValues: new object[] { 9, 44 });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2001, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1980, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1983, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1995, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(2008, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthday",
                value: new DateTime(1978, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthday",
                value: new DateTime(1986, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Birthday",
                value: new DateTime(1971, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Birthday",
                value: new DateTime(1950, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Birthday",
                value: new DateTime(1979, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 5, 34 },
                    { 6, 34 },
                    { 5, 33 },
                    { 1, 33 },
                    { 6, 32 },
                    { 7, 28 },
                    { 6, 30 },
                    { 3, 30 },
                    { 1, 29 },
                    { 5, 29 },
                    { 2, 35 },
                    { 6, 31 },
                    { 4, 37 },
                    { 2, 40 },
                    { 3, 38 },
                    { 1, 39 },
                    { 6, 39 },
                    { 6, 40 },
                    { 3, 28 },
                    { 6, 41 },
                    { 1, 42 },
                    { 5, 42 },
                    { 1, 43 },
                    { 7, 43 },
                    { 8, 44 },
                    { 2, 44 },
                    { 5, 45 },
                    { 1, 37 },
                    { 5, 27 },
                    { 2, 41 },
                    { 5, 26 }
                });

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Actor_Id", "Movie_Id" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 2, 10 },
                    { 7, 9 },
                    { 3, 8 },
                    { 9, 8 },
                    { 7, 6 },
                    { 1, 6 },
                    { 1, 12 },
                    { 9, 5 },
                    { 2, 4 },
                    { 9, 4 },
                    { 7, 3 },
                    { 6, 3 },
                    { 8, 2 },
                    { 7, 2 },
                    { 7, 1 },
                    { 7, 5 },
                    { 7, 26 },
                    { 8, 14 },
                    { 8, 21 },
                    { 8, 24 },
                    { 7, 23 },
                    { 4, 23 },
                    { 2, 22 },
                    { 4, 22 },
                    { 6, 21 },
                    { 3, 15 },
                    { 9, 25 },
                    { 9, 20 },
                    { 3, 19 },
                    { 8, 18 },
                    { 6, 18 },
                    { 1, 17 },
                    { 9, 17 },
                    { 8, 16 },
                    { 8, 15 },
                    { 5, 20 },
                    { 1, 25 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "RelaseDate",
                value: new DateTime(2013, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "RelaseDate",
                value: new DateTime(2013, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "RelaseDate",
                value: new DateTime(2005, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "RelaseDate",
                value: new DateTime(2012, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "RelaseDate",
                value: new DateTime(2009, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "RelaseDate",
                value: new DateTime(2012, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "RelaseDate",
                value: new DateTime(2002, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "RelaseDate",
                value: new DateTime(2009, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "RelaseDate",
                value: new DateTime(2010, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "RelaseDate",
                value: new DateTime(2000, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "RelaseDate",
                value: new DateTime(2008, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "RelaseDate",
                value: new DateTime(2008, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "RelaseDate",
                value: new DateTime(2010, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "RelaseDate",
                value: new DateTime(2017, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "RelaseDate",
                value: new DateTime(2012, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "RelaseDate",
                value: new DateTime(2013, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "RelaseDate",
                value: new DateTime(2001, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "RelaseDate",
                value: new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "RelaseDate",
                value: new DateTime(2008, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "RelaseDate",
                value: new DateTime(2011, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "RelaseDate",
                value: new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "RelaseDate",
                value: new DateTime(2006, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "RelaseDate",
                value: new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "RelaseDate",
                value: new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "RelaseDate",
                value: new DateTime(2014, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "RelaseDate",
                value: new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "RelaseDate",
                value: new DateTime(2011, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "RelaseDate",
                value: new DateTime(2012, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "RelaseDate",
                value: new DateTime(2011, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "RelaseDate",
                value: new DateTime(2000, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "RelaseDate",
                value: new DateTime(2003, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "RelaseDate",
                value: new DateTime(2000, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "RelaseDate",
                value: new DateTime(2006, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "RelaseDate",
                value: new DateTime(2012, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "RelaseDate",
                value: new DateTime(2001, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "RelaseDate",
                value: new DateTime(2005, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "RelaseDate",
                value: new DateTime(2010, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "RelaseDate",
                value: new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "RelaseDate",
                value: new DateTime(2015, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "RelaseDate",
                value: new DateTime(2016, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "RelaseDate",
                value: new DateTime(2015, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "RelaseDate",
                value: new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "RelaseDate",
                value: new DateTime(2010, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "RelaseDate",
                value: new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "RelaseDate",
                value: new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
