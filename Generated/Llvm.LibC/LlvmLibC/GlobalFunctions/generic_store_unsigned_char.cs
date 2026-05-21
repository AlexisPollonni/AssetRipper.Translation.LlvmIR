using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_store_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeIhEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned char>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value)
	{
		store_unsigned_char.Invoke(dst, value);
	}
}
