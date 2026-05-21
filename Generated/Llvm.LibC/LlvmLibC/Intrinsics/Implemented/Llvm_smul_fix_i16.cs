using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_smul_fix_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.smul.fix.i16")]
	[DemangledName("llvm.smul.fix.i16")]
	public static short Invoke(short a, short b, int scale)
	{
		return IntrinsicFunctions.llvm_smul_fix_i16(a, b, scale);
	}
}
