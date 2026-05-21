using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_short_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE8TypedIntItEC2Et")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::TypedInt<unsigned short>::TypedInt(unsigned short)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned short")] short value)
	{
		unchecked((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = value;
	}
}
