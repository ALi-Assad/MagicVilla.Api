using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaApI.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Detials", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pool, Wi-Fi, Breakfast", new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8031), "A beautiful villa with a stunning sunset view.", "https://example.com/images/sunset_villa.jpg", "Sunset Villa", 4, 250.0, 1500, new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8042) },
                    { 2, "Fireplace, Hiking Trails, Wi-Fi", new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8046), "A cozy retreat in the mountains.", "https://example.com/images/mountain_retreat.jpg", "Mountain Retreat", 6, 300.0, 2000, new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8047) },
                    { 3, "Beach Access, Wi-Fi, BBQ Grill", new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8049), "A charming bungalow right on the beach.", "https://example.com/images/beachfront_bungalow.jpg", "Beachfront Bungalow", 5, 400.0, 1800, new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8050) },
                    { 4, "Wi-Fi, Gym, Rooftop Access", new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8053), "A modern loft with a view of the city lights.", "https://example.com/images/city_lights_loft.jpg", "City Lights Loft", 3, 350.0, 1200, new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8053) },
                    { 5, "Garden, Wi-Fi, Fireplace", new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8056), "A quaint cottage in the countryside.", "https://example.com/images/countryside_cottage.jpg", "Countryside Cottage", 4, 200.0, 1400, new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8056) },
                    { 6, "Lake Access, Wi-Fi, Hot Tub", new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8059), "A luxurious lodge with a view of the lake.", "https://example.com/images/lakeview_lodge.jpg", "Lakeview Lodge", 8, 450.0, 2200, new DateTime(2024, 9, 17, 19, 42, 40, 397, DateTimeKind.Local).AddTicks(8060) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
