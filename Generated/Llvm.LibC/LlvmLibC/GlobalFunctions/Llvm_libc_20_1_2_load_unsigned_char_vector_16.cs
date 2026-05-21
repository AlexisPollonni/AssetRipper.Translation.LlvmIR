using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_load_unsigned_char_vector_16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadIDv16_hEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned char vector[16] __llvm_libc_20_1_2_::load<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned char vector[16]")]
	public unsafe static InlineArray16_SByte Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr)
	{
		InlineArray16_SByte inlineArray16_SByte = default(InlineArray16_SByte);
		Llvm_lifetime_start_p0.Invoke(16L, &inlineArray16_SByte);
		inlineArray16_SByte = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
		{
			170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
			170, 170, 170, 170, 170, 170
		});
		Llvm_libc_20_1_2_memcpy_inline_16ul.Invoke(&inlineArray16_SByte, Ptr);
		InlineArray16_SByte result = inlineArray16_SByte;
		Llvm_lifetime_end_p0.Invoke(16L, &inlineArray16_SByte);
		return result;
	}
}
