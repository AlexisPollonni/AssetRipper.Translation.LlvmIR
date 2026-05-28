using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_store_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeImEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned long>(__llvm_libc_20_1_2_::cpp::byte*, unsigned long)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned long")] long Value)
	{
		Store_unsigned_long.Invoke(Dst, Value);
	}
}
