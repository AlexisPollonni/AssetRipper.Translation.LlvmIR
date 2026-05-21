using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_store_unsigned_char_vector_16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeIDv16_hEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char vector[16])")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char vector[16]")] InlineArray16_SByte Value)
	{
		Llvm_libc_20_1_2_store_unsigned_char_vector_16.Invoke(Dst, Value);
	}
}
