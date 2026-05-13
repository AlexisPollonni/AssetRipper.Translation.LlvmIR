using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4loadIDv16_hEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned char vector[16] __llvm_libc_20_1_2_::load<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_char_vector_16_load_unsigned_char_vector_16_cpp_byte_const
{
	public unsafe static InlineArray16_SByte Invoke(void* ptr)
	{
		InlineArray16_SByte inlineArray16_SByte = default(InlineArray16_SByte);
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray16_SByte);
		inlineArray16_SByte = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
		{
			170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
			170, 170, 170, 170, 170, 170
		});
		void_memcpy_inline_16ul_void_void_const.Invoke(&inlineArray16_SByte, ptr);
		InlineArray16_SByte result = inlineArray16_SByte;
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray16_SByte);
		return result;
	}
}
