using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_umul_fix_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.umul.fix.i16")]
	[DemangledName("llvm.umul.fix.i16")]
	public static short Invoke(short a, short b, int scale)
	{
		return IntrinsicFunctions.llvm_umul_fix_i16(a, b, scale);
	}
}
