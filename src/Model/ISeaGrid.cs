﻿using System;
namespace MyGame
{
	public interface ISeaGrid
	{
		/// <summary>
		/// Gets the width.
		/// </summary>
		/// <value>The width.</value>
		int Width { get; }

		/// <summary>
		/// Gets the height.
		/// </summary>
		/// <value>The height.</value>
		int Height { get; }

		/// <summary>
		/// Indicates that the grid has changed.
		/// </summary>
		event EventHandler Changed;

		/// <summary>
		/// Provides access to the given row/column
		/// </summary>
		/// <param name="row">the row to access</param>
		/// <param name="column">the column to access</param>
		/// <value>what the player can see at that location</value>
		/// <returns>what the player can see at that location</returns>
		//TileView Item { get; }
		TileView this [int row, int column] { get; }

		/// <summary>
		/// Mark the indicated tile as shot.
		/// </summary>
		/// <param name="row">the row of the tile</param>
		/// <param name="col">the column of the tile</param>
		/// <returns>the result of the attack</returns>
		AttackResult HitTile (int row, int col);
	}
}
