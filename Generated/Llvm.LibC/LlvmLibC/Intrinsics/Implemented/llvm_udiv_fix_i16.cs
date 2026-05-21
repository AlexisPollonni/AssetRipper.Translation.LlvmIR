using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_udiv_fix_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.udiv.fix.i16")]
	[DemangledName("llvm.udiv.fix.i16")]
	public static short Invoke(short a, short b, int scale)
	{
		return IntrinsicFunctions.llvm_udiv_fix_i16(a, b, scale);
	}
}
