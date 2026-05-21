using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class store_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5storeIhEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::store<unsigned char>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* ptr, [NativeType("unsigned char")] sbyte value)
	{
		sbyte b = value;
		memcpy_inline_1ul.Invoke(ptr, &b);
	}
}
