using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE10make_arrayEmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::make_array(unsigned long, unsigned long) const")]
internal static partial class internal_ArrayFixedSize_4ul_make_array_unsigned_long_unsigned_long_const
{
	public unsafe static Struct_kqhe8i Invoke(void* @this, long i, long s)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		internal_ArrayFixedSize_4ul_ArrayFixedSize_void_unsigned_long.Invoke(&cpp_string_view2, internal_ArrayFixedSize_4ul_get_internal_unsigned_long_const.Invoke(@this, i), s);
		return *unchecked((Struct_kqhe8i*)(&cpp_string_view2));
	}
}
