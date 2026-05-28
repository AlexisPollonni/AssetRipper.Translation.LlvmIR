using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Store_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5storeIhEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::store<unsigned char>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Ptr, [MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		sbyte b = Value;
		Memcpy_inline_1ul.Invoke(Ptr, &b);
	}
}
