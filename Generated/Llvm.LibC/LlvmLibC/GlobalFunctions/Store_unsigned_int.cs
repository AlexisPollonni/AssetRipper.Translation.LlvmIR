using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Store_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5storeIjEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::store<unsigned int>(__llvm_libc_20_1_2_::cpp::byte*, unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Ptr, [MangledName("value")][NativeType("unsigned int")] int Value)
	{
		int num = Value;
		Memcpy_inline_4ul.Invoke(Ptr, &num);
	}
}
