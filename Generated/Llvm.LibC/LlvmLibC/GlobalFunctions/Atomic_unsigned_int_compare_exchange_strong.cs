using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_int_compare_exchange_strong
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjE23compare_exchange_strongERjjNS0_11MemoryOrderENS0_11MemoryScopeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::compare_exchange_strong(unsigned int&, unsigned int, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("expected")][NativeType("unsigned int&")] void* Expected, [MangledName("desired")][NativeType("unsigned int")] int Desired, [MangledName("mem_ord")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder Mem_ord, [MangledName("mem_scope")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryScope")] MemoryScope Mem_scope)
	{
		int num = Desired;
		unchecked
		{
			void* location = Atomic_unsigned_int_addressof.Invoke(&((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0);
			int num2 = Atomic_unsigned_int_order.Invoke(Mem_ord);
			void* ptr = Atomic_unsigned_int_addressof.Invoke(Expected);
			void* ptr2 = Atomic_unsigned_int_addressof.Invoke(&num);
			int num3 = Atomic_unsigned_int_order.Invoke(Mem_ord);
			sbyte b;
			switch (num2)
			{
			default:
			{
				int num6 = num3;
				if (num6 != 1 && num6 != 2)
				{
					if (num6 != 5)
					{
						Unsafe.SkipInit(out bool field_26);
						int field_25 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_26);
						Struct_ycs3bi struct_ycs3bi19 = new Struct_ycs3bi
						{
							field_0 = field_25,
							field_1 = field_26
						};
						Struct_ycs3bi struct_ycs3bi20 = struct_ycs3bi19;
						int field_27 = struct_ycs3bi20.field_0;
						Struct_ycs3bi struct_ycs3bi21 = struct_ycs3bi19;
						bool field_28 = struct_ycs3bi21.field_1;
						if (!field_28)
						{
							*(int*)ptr = field_27;
						}
						b = (field_28 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_30);
						int field_29 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_30);
						Struct_ycs3bi struct_ycs3bi22 = new Struct_ycs3bi
						{
							field_0 = field_29,
							field_1 = field_30
						};
						Struct_ycs3bi struct_ycs3bi23 = struct_ycs3bi22;
						int field_31 = struct_ycs3bi23.field_0;
						Struct_ycs3bi struct_ycs3bi24 = struct_ycs3bi22;
						bool field_32 = struct_ycs3bi24.field_1;
						if (!field_32)
						{
							*(int*)ptr = field_31;
						}
						b = (field_32 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_34);
					int field_33 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_34);
					Struct_ycs3bi struct_ycs3bi25 = new Struct_ycs3bi
					{
						field_0 = field_33,
						field_1 = field_34
					};
					Struct_ycs3bi struct_ycs3bi26 = struct_ycs3bi25;
					int field_35 = struct_ycs3bi26.field_0;
					Struct_ycs3bi struct_ycs3bi27 = struct_ycs3bi25;
					bool field_36 = struct_ycs3bi27.field_1;
					if (!field_36)
					{
						*(int*)ptr = field_35;
					}
					b = (field_36 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 1:
			case 2:
			{
				int num8 = num3;
				if (num8 != 1 && num8 != 2)
				{
					if (num8 != 5)
					{
						Unsafe.SkipInit(out bool field_50);
						int field_49 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_50);
						Struct_ycs3bi struct_ycs3bi37 = new Struct_ycs3bi
						{
							field_0 = field_49,
							field_1 = field_50
						};
						Struct_ycs3bi struct_ycs3bi38 = struct_ycs3bi37;
						int field_51 = struct_ycs3bi38.field_0;
						Struct_ycs3bi struct_ycs3bi39 = struct_ycs3bi37;
						bool field_52 = struct_ycs3bi39.field_1;
						if (!field_52)
						{
							*(int*)ptr = field_51;
						}
						b = (field_52 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_54);
						int field_53 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_54);
						Struct_ycs3bi struct_ycs3bi40 = new Struct_ycs3bi
						{
							field_0 = field_53,
							field_1 = field_54
						};
						Struct_ycs3bi struct_ycs3bi41 = struct_ycs3bi40;
						int field_55 = struct_ycs3bi41.field_0;
						Struct_ycs3bi struct_ycs3bi42 = struct_ycs3bi40;
						bool field_56 = struct_ycs3bi42.field_1;
						if (!field_56)
						{
							*(int*)ptr = field_55;
						}
						b = (field_56 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_58);
					int field_57 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_58);
					Struct_ycs3bi struct_ycs3bi43 = new Struct_ycs3bi
					{
						field_0 = field_57,
						field_1 = field_58
					};
					Struct_ycs3bi struct_ycs3bi44 = struct_ycs3bi43;
					int field_59 = struct_ycs3bi44.field_0;
					Struct_ycs3bi struct_ycs3bi45 = struct_ycs3bi43;
					bool field_60 = struct_ycs3bi45.field_1;
					if (!field_60)
					{
						*(int*)ptr = field_59;
					}
					b = (field_60 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 3:
			{
				int num5 = num3;
				if (num5 != 1 && num5 != 2)
				{
					if (num5 != 5)
					{
						Unsafe.SkipInit(out bool field_14);
						int field_13 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_14);
						Struct_ycs3bi struct_ycs3bi10 = new Struct_ycs3bi
						{
							field_0 = field_13,
							field_1 = field_14
						};
						Struct_ycs3bi struct_ycs3bi11 = struct_ycs3bi10;
						int field_15 = struct_ycs3bi11.field_0;
						Struct_ycs3bi struct_ycs3bi12 = struct_ycs3bi10;
						bool field_16 = struct_ycs3bi12.field_1;
						if (!field_16)
						{
							*(int*)ptr = field_15;
						}
						b = (field_16 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_18);
						int field_17 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_18);
						Struct_ycs3bi struct_ycs3bi13 = new Struct_ycs3bi
						{
							field_0 = field_17,
							field_1 = field_18
						};
						Struct_ycs3bi struct_ycs3bi14 = struct_ycs3bi13;
						int field_19 = struct_ycs3bi14.field_0;
						Struct_ycs3bi struct_ycs3bi15 = struct_ycs3bi13;
						bool field_20 = struct_ycs3bi15.field_1;
						if (!field_20)
						{
							*(int*)ptr = field_19;
						}
						b = (field_20 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_22);
					int field_21 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_22);
					Struct_ycs3bi struct_ycs3bi16 = new Struct_ycs3bi
					{
						field_0 = field_21,
						field_1 = field_22
					};
					Struct_ycs3bi struct_ycs3bi17 = struct_ycs3bi16;
					int field_23 = struct_ycs3bi17.field_0;
					Struct_ycs3bi struct_ycs3bi18 = struct_ycs3bi16;
					bool field_24 = struct_ycs3bi18.field_1;
					if (!field_24)
					{
						*(int*)ptr = field_23;
					}
					b = (field_24 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 4:
			{
				int num7 = num3;
				if (num7 != 1 && num7 != 2)
				{
					if (num7 != 5)
					{
						Unsafe.SkipInit(out bool field_38);
						int field_37 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_38);
						Struct_ycs3bi struct_ycs3bi28 = new Struct_ycs3bi
						{
							field_0 = field_37,
							field_1 = field_38
						};
						Struct_ycs3bi struct_ycs3bi29 = struct_ycs3bi28;
						int field_39 = struct_ycs3bi29.field_0;
						Struct_ycs3bi struct_ycs3bi30 = struct_ycs3bi28;
						bool field_40 = struct_ycs3bi30.field_1;
						if (!field_40)
						{
							*(int*)ptr = field_39;
						}
						b = (field_40 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_42);
						int field_41 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_42);
						Struct_ycs3bi struct_ycs3bi31 = new Struct_ycs3bi
						{
							field_0 = field_41,
							field_1 = field_42
						};
						Struct_ycs3bi struct_ycs3bi32 = struct_ycs3bi31;
						int field_43 = struct_ycs3bi32.field_0;
						Struct_ycs3bi struct_ycs3bi33 = struct_ycs3bi31;
						bool field_44 = struct_ycs3bi33.field_1;
						if (!field_44)
						{
							*(int*)ptr = field_43;
						}
						b = (field_44 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_46);
					int field_45 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_46);
					Struct_ycs3bi struct_ycs3bi34 = new Struct_ycs3bi
					{
						field_0 = field_45,
						field_1 = field_46
					};
					Struct_ycs3bi struct_ycs3bi35 = struct_ycs3bi34;
					int field_47 = struct_ycs3bi35.field_0;
					Struct_ycs3bi struct_ycs3bi36 = struct_ycs3bi34;
					bool field_48 = struct_ycs3bi36.field_1;
					if (!field_48)
					{
						*(int*)ptr = field_47;
					}
					b = (field_48 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 5:
			{
				int num4 = num3;
				if (num4 != 1 && num4 != 2)
				{
					if (num4 != 5)
					{
						Unsafe.SkipInit(out bool field_2);
						int field_ = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_2);
						Struct_ycs3bi struct_ycs3bi = new Struct_ycs3bi
						{
							field_0 = field_,
							field_1 = field_2
						};
						Struct_ycs3bi struct_ycs3bi2 = struct_ycs3bi;
						int field_3 = struct_ycs3bi2.field_0;
						Struct_ycs3bi struct_ycs3bi3 = struct_ycs3bi;
						bool field_4 = struct_ycs3bi3.field_1;
						if (!field_4)
						{
							*(int*)ptr = field_3;
						}
						b = (field_4 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_6);
						int field_5 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_6);
						Struct_ycs3bi struct_ycs3bi4 = new Struct_ycs3bi
						{
							field_0 = field_5,
							field_1 = field_6
						};
						Struct_ycs3bi struct_ycs3bi5 = struct_ycs3bi4;
						int field_7 = struct_ycs3bi5.field_0;
						Struct_ycs3bi struct_ycs3bi6 = struct_ycs3bi4;
						bool field_8 = struct_ycs3bi6.field_1;
						if (!field_8)
						{
							*(int*)ptr = field_7;
						}
						b = (field_8 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_10);
					int field_9 = InstructionHelper.AtomicCompareExchangeInt32(comparand: *(int*)ptr, location: location, value: *(int*)ptr2, exchanged: &field_10);
					Struct_ycs3bi struct_ycs3bi7 = new Struct_ycs3bi
					{
						field_0 = field_9,
						field_1 = field_10
					};
					Struct_ycs3bi struct_ycs3bi8 = struct_ycs3bi7;
					int field_11 = struct_ycs3bi8.field_0;
					Struct_ycs3bi struct_ycs3bi9 = struct_ycs3bi7;
					bool field_12 = struct_ycs3bi9.field_1;
					if (!field_12)
					{
						*(int*)ptr = field_11;
					}
					b = (field_12 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			}
			return (b & 1) == 1;
		}
	}
}
