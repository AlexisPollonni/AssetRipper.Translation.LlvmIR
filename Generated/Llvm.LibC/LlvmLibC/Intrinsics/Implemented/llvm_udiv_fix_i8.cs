using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.udiv.fix.i8")]
[DemangledName("llvm.udiv.fix.i8")]
internal static partial class llvm_udiv_fix_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte Invoke(sbyte a, sbyte b, int scale)
	{
		return IntrinsicFunctions.llvm_udiv_fix_i8(a, b, scale);
	}
}
