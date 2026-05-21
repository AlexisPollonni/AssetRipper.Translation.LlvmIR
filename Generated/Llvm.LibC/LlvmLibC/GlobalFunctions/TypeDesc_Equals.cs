using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypeDesc_Equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_11printf_core8TypeDesceqERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc::operator==(__llvm_libc_20_1_2_::printf_core::TypeDesc const&) const")]
	public unsafe static bool Invoke(printf_core_TypeDesc* @this, [NativeType("__llvm_libc_20_1_2_::printf_core::TypeDesc const&")] printf_core_TypeDesc* other)
	{
		return unchecked((byte)@this->size == (byte)other->size && (byte)@this->primary_type == (byte)other->primary_type);
	}
}
