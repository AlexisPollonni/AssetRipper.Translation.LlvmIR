using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.usub.with.overflow.i32")]
[DemangledName("llvm.usub.with.overflow.i32")]
internal static partial class llvm_usub_with_overflow_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Struct_ycs3bi Invoke(int parameter_0, int parameter_1)
	{
		return unchecked(new Struct_ycs3bi
		{
			field_0 = parameter_0 - parameter_1,
			field_1 = ((uint)parameter_0 < (uint)parameter_1)
		});
	}
}
