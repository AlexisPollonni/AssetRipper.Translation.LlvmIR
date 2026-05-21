using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class store_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5storeImEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::store<unsigned long>(__llvm_libc_20_1_2_::cpp::byte*, unsigned long)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* ptr, [NativeType("unsigned long")] long value)
	{
		long num = value;
		memcpy_inline_8ul.Invoke(ptr, &num);
	}
}
