using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypeDesc_Equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_11printf_core8TypeDesceqERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc::operator==(__llvm_libc_20_1_2_::printf_core::TypeDesc const&) const")]
	public unsafe static bool Invoke([MangledName("this")] Printf_core_TypeDesc* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::printf_core::TypeDesc const&")] Printf_core_TypeDesc* Other)
	{
		return unchecked((byte)This->Size == (byte)Other->Size && (byte)This->Primary_type == (byte)Other->Primary_type);
	}
}
