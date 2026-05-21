using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_16ul_make_array
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm16EE10make_arrayEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>::make_array(unsigned long, unsigned long) const")]
	public unsafe static Struct_kqhe8i Invoke(void* @this, [NativeType("unsigned long")] long i, [NativeType("unsigned long")] long s)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		ArrayFixedSize_16ul_Constructor.Invoke(&cpp_string_view2, ArrayFixedSize_16ul_get_internal.Invoke(@this, i), s);
		return *unchecked((Struct_kqhe8i*)(&cpp_string_view2));
	}
}
