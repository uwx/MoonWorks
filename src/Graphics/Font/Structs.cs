using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace MoonWorks.Graphics.Font
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vertex : IVertexType
	{
		public Vector2 Position;
		public Vector2 TexCoord;
		public uint ChunkIndex;

		public static ReadOnlySpan<VertexElementFormat> Formats =>
		[
			VertexElementFormat.Float2,
			VertexElementFormat.Float2,
			VertexElementFormat.Uint
		];

		public static ReadOnlySpan<uint> Offsets =>
		[
			0,
			8,
			16
		];
	}
}
