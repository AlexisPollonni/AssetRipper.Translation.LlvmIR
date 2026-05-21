using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_Constructor_hus89e
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEEC2EPKcRS3_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::Parser(char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	[CleanName("Parser_internal_ArgList_Constructor")]
	public unsafe static void Invoke(printf_core_Parser* @this, [NativeType("char const*")] void* new_str, [NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] internal_ArgList* args)
	{
		@this->str = new_str;
		@this->cur_pos = 0L;
		ArgList_Constructor_z4jw9r.Invoke(&@this->args_cur, args);
		ArgList_Constructor_z4jw9r.Invoke(&@this->args_start, args);
		@this->args_index = 1L;
		InlineArray128_printf_core_TypeDesc* desc_arr = &@this->desc_arr;
		unchecked
		{
			*(short*)desc_arr = printf_core_type_desc_from_type_void_kvifr8.Invoke();
			nint num = (nint)((byte*)desc_arr + sizeof(printf_core_TypeDesc));
			printf_core_TypeDesc* ptr = (printf_core_TypeDesc*)desc_arr + 128L;
			while (true)
			{
				void* ptr2 = (void*)num;
				((printf_core_TypeDesc*)ptr2)->size = 0;
				((printf_core_TypeDesc*)ptr2)->primary_type = PrimaryType.Unknown;
				printf_core_TypeDesc* ptr3 = (printf_core_TypeDesc*)ptr2 + 1;
				if (ptr3 != ptr)
				{
					num = (nint)ptr3;
					continue;
				}
				break;
			}
		}
	}
}
