using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_store_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeItEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned short>(__llvm_libc_20_1_2_::cpp::byte*, unsigned short)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned short")] short Value)
	{
		Store_unsigned_short.Invoke(Dst, Value);
	}
}
