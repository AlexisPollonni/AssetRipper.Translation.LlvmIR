using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_udiv_fix_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.udiv.fix.i8")]
	[DemangledName("llvm.udiv.fix.i8")]
	public static sbyte Invoke(sbyte a, sbyte b, int scale)
	{
		return IntrinsicFunctions.llvm_udiv_fix_i8(a, b, scale);
	}
}
