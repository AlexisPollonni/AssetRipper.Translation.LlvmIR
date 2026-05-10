using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12sub_overflowItEEbT_S1_RS1_")]
[DemangledName("bool __llvm_libc_20_1_2_::sub_overflow<unsigned short>(unsigned short, unsigned short, unsigned short&)")]
internal static partial class bool_sub_overflow_unsigned_short_unsigned_short_unsigned_short_unsigned_short
{
	public unsafe static bool Invoke(short a, short b, void* res)
	{
		Struct_yzqsj9 struct_yzqsj = llvm_usub_with_overflow_i16.Invoke(a, b);
		Struct_yzqsj9 struct_yzqsj2 = struct_yzqsj;
		bool field_ = struct_yzqsj2.field_1;
		Struct_yzqsj9 struct_yzqsj3 = struct_yzqsj;
		*unchecked((short*)res) = struct_yzqsj3.field_0;
		return field_;
	}
}
