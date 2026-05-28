using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_8ul_make_array
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm8EE10make_arrayEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>::make_array(unsigned long, unsigned long) const")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		ArrayFixedSize_8ul_Constructor.Invoke(&cpp_string_view, ArrayFixedSize_8ul_get_internal.Invoke(This, I), S);
		return *unchecked((Struct_kqhe8i*)(&cpp_string_view));
	}
}
