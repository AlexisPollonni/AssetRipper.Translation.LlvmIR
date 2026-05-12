using System;
using System.Runtime.CompilerServices;

namespace LlvmLibC.Intrinsics.Unimplemented;

internal static partial class ungetc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(int parameter_0, void* parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: ungetc");
	}
}
