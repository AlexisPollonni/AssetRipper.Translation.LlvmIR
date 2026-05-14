using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.umul.fix.i8")]
[DemangledName("llvm.umul.fix.i8")]
internal static partial class llvm_umul_fix_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte Invoke(sbyte a, sbyte b, int scale)
	{
		return IntrinsicFunctions.llvm_umul_fix_i8(a, b, scale);
	}
}
