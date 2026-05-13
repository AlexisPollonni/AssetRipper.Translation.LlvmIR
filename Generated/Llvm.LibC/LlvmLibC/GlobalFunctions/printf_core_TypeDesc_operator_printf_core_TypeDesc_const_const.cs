using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_11printf_core8TypeDesceqERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc::operator==(__llvm_libc_20_1_2_::printf_core::TypeDesc const&) const")]
internal static partial class printf_core_TypeDesc_operator_printf_core_TypeDesc_const_const
{
	public unsafe static bool Invoke(printf_core_TypeDesc* @this, printf_core_TypeDesc* other)
	{
		return unchecked((byte)@this->size == (byte)other->size && (byte)@this->primary_type == (byte)other->primary_type);
	}
}
