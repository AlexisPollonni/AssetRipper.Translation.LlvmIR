using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.usub.with.overflow.i16")]
[DemangledName("llvm.usub.with.overflow.i16")]
internal static partial class llvm_usub_with_overflow_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Struct_yzqsj9 Invoke(short parameter_0, short parameter_1)
	{
		return unchecked(new Struct_yzqsj9
		{
			field_0 = (short)(parameter_0 - parameter_1),
			field_1 = ((uint)(ushort)parameter_0 < (uint)(ushort)parameter_1)
		});
	}
}
