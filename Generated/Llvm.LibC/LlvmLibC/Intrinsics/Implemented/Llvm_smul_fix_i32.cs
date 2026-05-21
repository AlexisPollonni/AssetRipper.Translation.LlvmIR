using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_smul_fix_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.smul.fix.i32")]
	[DemangledName("llvm.smul.fix.i32")]
	public static int Invoke(int a, int b, int scale)
	{
		return IntrinsicFunctions.llvm_smul_fix_i32(a, b, scale);
	}
}
