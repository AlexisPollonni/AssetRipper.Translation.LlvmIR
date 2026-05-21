using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class store_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5storeItEEvPNS_3cpp4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::store<unsigned short>(__llvm_libc_20_1_2_::cpp::byte*, unsigned short)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* ptr, [NativeType("unsigned short")] short value)
	{
		short num = value;
		memcpy_inline_2ul.Invoke(ptr, &num);
	}
}
