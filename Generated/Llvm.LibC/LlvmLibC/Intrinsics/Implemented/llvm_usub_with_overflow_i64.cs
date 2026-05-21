using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_usub_with_overflow_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.usub.with.overflow.i64")]
	[DemangledName("llvm.usub.with.overflow.i64")]
	public static Struct_u6p3uf Invoke(long parameter_0, long parameter_1)
	{
		return unchecked(new Struct_u6p3uf
		{
			field_0 = parameter_0 - parameter_1,
			field_1 = ((ulong)parameter_0 < (ulong)parameter_1)
		});
	}
}
