using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

internal static partial class store_unsigned_char_vector_16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5storeIDv16_hEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::store<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char vector[16])")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* ptr, [NativeType("unsigned char vector[16]")] InlineArray16_SByte value)
	{
		InlineArray16_SByte inlineArray16_SByte = value;
		memcpy_inline_16ul.Invoke(ptr, &inlineArray16_SByte);
	}
}
